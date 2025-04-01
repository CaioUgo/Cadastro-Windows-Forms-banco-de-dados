using MySql.Data.MySqlClient;
using Mysqlx.Connection;

namespace Integração_com_bancos_de_dados_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                if (usuario != "" && senha != "")
                {
                    string conexaoBanco = "Server=localHost; Database=sistemaLogin;Uid=root;pwd=''";

                    MySqlConnection conexao = new MySqlConnection(conexaoBanco);

                    conexao.Open();

                    string consultaUsuario = "Select * from usuarios where usuario = @usuario and senha = @senha";
                    MySqlCommand comandoSQL = new MySqlCommand(consultaUsuario, conexao);
                    comandoSQL.Parameters.AddWithValue("@usuario", usuario);
                    comandoSQL.Parameters.AddWithValue("@senha", senha);

                    int registro = Convert.ToInt32(comandoSQL.ExecuteScalar());

                    if (registro > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválido!");
                    }

                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login" + ex.Message);
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
