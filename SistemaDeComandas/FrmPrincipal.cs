using Microsoft.EntityFrameworkCore;
using SistemaDeComandas.BancoDeDados;

namespace SistemaDeComandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            criarBancoDeDados();

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
