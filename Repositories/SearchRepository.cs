using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace baterias.Repositories
{
    public class SearchRepository
    {
        public DataTable SearchData(string pesquisa)
        {
            if (string.IsNullOrEmpty(pesquisa))
                throw new ArgumentException("Digite um valor para pesquisar.");

            // Caminho para o banco de dados SQLite
            string dbPath = Path.Combine(Application.StartupPath, "bateria2.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            // Criar a consulta para pesquisar os carros com as baterias relacionadas
            string query = @"SELECT m.marca AS Marca,
                                        c.nome AS Carro, 
                                        c.ano AS Ano, 
                                        b.amper AS Amperagem, 
                                        b.cca AS CCA,
                                        b.lado AS Lado
                                 FROM carro c
                                 INNER JOIN bateria b 
                                    ON c.bateria = b.idbat
                                 INNER JOIN modelo m 
                                    ON c.idmarca = m.idmarca
                                 WHERE c.nome LIKE @pesquisa;";

            // Criar um DataTable para armazenar os resultados
            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Executar a consulta
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Passar o valor da pesquisa como parâmetro
                    cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");

                    // Preencher o DataTable com os resultados
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                return dt;
            }
        }
    }
}