using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using baterias.Repositories;
using System.Data.SqlClient;

namespace baterias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para o campo de texto do usuário
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            // Se necessário, adicione algum código para lidar com a mudança no campo do usuário
        }

        // Evento para o campo de texto da senha
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            // Se necessário, adicione algum código para lidar com a mudança no campo da senha
        }

        // Evento para o botão de login
        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Obter o nome de usuário e a senha inseridos
            string usuario = txtUser.Text;
            string senha = txtPass.Text;

            UserRepository userRepository = new UserRepository();

            try
            {

                bool isLoginSuccessful = userRepository.Login(usuario, senha);

                if (isLoginSuccessful)
                {
                    MessageBox.Show("Login bem-sucedido!");
                    Hide();
                    Principal principalForm = new Principal();
                    principalForm.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos ou erro ao conectar com o banco de dados.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}