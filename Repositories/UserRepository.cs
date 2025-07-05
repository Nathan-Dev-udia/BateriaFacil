using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace baterias.Repositories
{
    public class UserRepository
    {
        public bool Login(string usuario, string senha)
        {
            // Caminho para o banco de dados SQLite
            string dbPath = Path.Combine(Application.StartupPath, "bateria2.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Consultar o banco de dados para verificar o usuário e a senha
                    string query = @"SELECT COUNT(*) 
                                     FROM usuarios 
                                     WHERE nome = @usuario 
                                     AND senha = @senha;";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // Passar os parâmetros para evitar SQL Injection
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        // Se a contagem for maior que zero, login é bem-sucedido
                        return result > 0;
                    }
                }
                catch (SQLiteException ex)
                {
                    throw new SQLiteException("Erro ao tentar realizar o login: " + ex.Message, ex);
                }
            }
        }
    }
}