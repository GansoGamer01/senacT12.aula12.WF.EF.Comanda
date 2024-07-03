﻿using SistemaDeComandas.BancoDeDados;
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
        public FrmUsuario()
        {
            InitializeComponent();
            carregarUsuarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CriarUsuario();
            AtualizarUsuario();
        }

        private void carregarUsuarios()
        {
            using (var banco = new ComandaContexto()) 
            {
                // consulta todos os usuarios na tabela usuarios (SELECT * FROM usuarios) \\
                var usuarios = banco.Usuarios.ToList();

                // dados da tabela usuarios serão exibidos no grid \\
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void AtualizarUsuario()
        {
            
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

                // salvar as alterações  (INSERT INTO Usuarios (id, Nome, Email) values() \\
                banco.SaveChanges();
            }
        }
    }
}
