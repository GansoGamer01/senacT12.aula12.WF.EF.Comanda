using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;

namespace SistemaDeComandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            criarBancoDeDados();
            criarUsuarioAdm();
        }

        private void criarUsuarioAdm()
        {
            // acessa o banco de dados \\
            using (var banco = new ComandaContexto())
            {
                //verificar se ja existe um admn \\
                // cria um novo usuario \\
                var novoUsuario = new Usuario();
                novoUsuario.Nome = "adm";
                novoUsuario.Email = "adm@comanda.com";
                novoUsuario.Senha = "123";

                // banco, adicione na coleção usuario um novo usuario \\
                banco.Usuarios.Add(novoUsuario);

                // confirmar a adição \\
                banco.SaveChanges();
            }
        }

        void criarBancoDeDados()
        {
            using (var banco = new ComandaContexto())
            {
                // criando um novo(new) contexto do banco \\
                banco.Database.Migrate();
            }
        }

        private void BtnCardapio_Click(object sender, EventArgs e)
        {
            // cria o form de cardapio e exibe para o humano \\
            new FrmCardapio().ShowDialog();
        }

        private void BtnComanda_Click(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog();
        }

        private void BtnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }
    }
}
