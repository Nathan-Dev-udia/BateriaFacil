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
            // Caminho para o banco de dados SQLite
            string dbPath = System.IO.Path.Combine(Application.StartupPath, "bateria2.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            // Obter o nome de usuário e a senha inseridos
            string usuario = txtUser.Text;
            string senha = txtPass.Text;

            // Verificar as credenciais no banco de dados
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consultar o banco de dados para verificar o usuário e a senha
                    string query = "SELECT COUNT(*) FROM usuarios WHERE nome = @usuario AND senha = @senha";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // Passar os parâmetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        // Se a contagem for maior que zero, login é bem-sucedido
                        if (result > 0)
                        {
                            MessageBox.Show("Login bem-sucedido!");

                            // Esconde o formulário de login
                            this.Hide();

                            // Abre o formulário principal
                            princial principalForm = new princial();
                            principalForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar com o banco de dados: {ex.Message}");
                }
            }
        }
    }
}