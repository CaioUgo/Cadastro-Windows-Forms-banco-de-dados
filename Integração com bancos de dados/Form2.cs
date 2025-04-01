using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integração_com_bancos_de_dados_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void labelCriarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtCriarUsuario.Text;
            string senha = txtCriarSenha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }

            string conexaoBanco = "Server=localhost; Database=sistemaLogin; Uid=root; pwd='';";

            try
            {

                using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
                {
                    conexao.Open();

                    string comandoSQL = "INSERT INTO usuarios (usuario, senha) VALUES (@usuario, @senha)";
                    using (MySqlCommand comando = new MySqlCommand(comandoSQL, conexao))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@senha", senha); 

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cadastro realizado com sucesso!");
                    LimparCampos();


                    this.Hide();

                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtCriarUsuario.Clear();
            txtCriarSenha.Clear();
        }

 
    }
}