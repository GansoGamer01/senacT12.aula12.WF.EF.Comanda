using SistemaDeComandas.BancoDeDados;
using SistemaDeComandas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeComandas
{
    public partial class FrmUsuario : Form
    {
        private bool eNovoUsuario;

        public FrmUsuario()
        {
            InitializeComponent();
            carregarUsuarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (eNovoUsuario)
                CriarUsuario();
            else
                AtualizarUsuario();

            desabilitarCampos();
            limparCampos();
            carregarUsuarios();
        }

        private void limparCampos()
        {
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtSenha.Enabled = false;
        }

        private void carregarUsuarios()
        {
            using (var banco = new ComandaContexto())
            {
                // consulta todos os usuarios na tabela usuarios (SELECT * FROM usuarios) \\
                var usuarios = banco.Usuarios.ToList();

                dgvUsuarios.DataSource = null;
                // dados da tabela usuarios serão exibidos no grid \\
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaContexto())
            {
                // buscar o usuario pelo ID \\
                var usuario = banco.Usuarios.First(usuario => usuario.Id == int.Parse(txtId.TextButton));

                // atualizar as propriedades \\
                usuario.Nome = txtNome.TextButton;
                usuario.Email = txtEmail.TextButton;
                usuario.Senha = txtSenha.TextButton;

                // salvar as alterações \\
                banco.SaveChanges();
            }
            MessageBox.Show("usuario atualizado com sucesso");
        }

        private void CriarUsuario()
        {   // validar se os campos estão preenchidos \\
            if (txtNome.TextButton == string.Empty)
            {
                MessageBox.Show("preencha o Nome");
                return;
            }

            if (txtEmail.TextButton == string.Empty)
            {
                MessageBox.Show("preencha o Email");
                return;
            }

            if (txtSenha.TextButton == string.Empty)
            {
                MessageBox.Show("preencha o Senha");
                return;
            }
            using (var banco = new ComandaContexto())
            {
                // criar objeto usuario \\
                var novoUsuario = new Usuario();
                novoUsuario.Nome = txtNome.Text;
                novoUsuario.Email = txtEmail.Text;
                novoUsuario.Senha = txtSenha.Text;

                // adiciona esse objeto no contexto do banco \\
                banco.Usuarios.Add(novoUsuario);

                // salvar as alterações  (INSERT INTO Usuarios (Nome, Email, senha) values() \\
                banco.SaveChanges();
            }
            MessageBox.Show("usuario cadastrado com sucesso");

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            // informa que está cadastrando um novo usuario \\
            eNovoUsuario = true;

            // limpa os campos da tela \\
            limparCampos();

            // chama o metodo que habilita os campos para digitação \\
            habilitaCampos();

        }

        private void habilitaCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            eNovoUsuario = false;

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // verificar se a linha foi selecionada \\
            if(e.RowIndex >= 0)
            {
                // obter a linha \\
                var linha = dgvUsuarios.Rows[e.RowIndex];

                // popular os campos da tela de acordo com a linha \\
                txtId.TextButton = linha.Cells["Id"].Value.ToString();
                txtNome.TextButton = linha.Cells["Nome"].Value.ToString();
                txtEmail.TextButton = linha.Cells["Email"].Value.ToString();
                txtSenha.TextButton = linha.Cells["Senha"].Value.ToString();

            }

            
        }
    }
}
