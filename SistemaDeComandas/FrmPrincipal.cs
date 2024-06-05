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
    }
}
