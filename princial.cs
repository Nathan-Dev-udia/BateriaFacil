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
    public partial class princial : Form
    {
        public princial()
        {
            InitializeComponent();

            this.FormClosing += princial_FormClosing;
        }

        //fechar a aplicação
        private void princial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Encerra completamente o programa
        }

        // Evento para o campo de pesquisa da bateria
        private void txtBat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Verifica se a tecla pressionada foi Enter
            {
                btnpesquisa_Click(sender, e);  // Chama o método de pesquisa
            }
        }

        // Evento para o botão de pesquisa
        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            // Obter o valor digitado no campo de pesquisa
            string pesquisa = txtBat.Text.Trim();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                // Caminho para o banco de dados SQLite
                string dbPath = System.IO.Path.Combine(Application.StartupPath, "bateria2.db");
                string connectionString = $"Data Source={dbPath};Version=3;";

                // Criar a consulta para pesquisar os carros com as baterias relacionadas
                string query = @"
        SELECT m.marca AS Marca, c.nome AS Carro, c.ano AS Ano, 
               b.amper AS Amperagem, b.cca AS CCA, b.lado AS Lado
        FROM carro c
        INNER JOIN bateria b ON c.bateria = b.idbat
        INNER JOIN modelo m ON c.idmarca = m.idmarca
        WHERE c.nome LIKE @pesquisa";

                // Criar um DataTable para armazenar os resultados
                DataTable dt = new DataTable();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    try
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

                        // Exibir os resultados no DataGridView
                        dataGridViewbat.DataSource = dt;

                        // Ajuste de exibição das colunas (se necessário)
                        dataGridViewbat.Columns["Carro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridViewbat.Columns["CCA"].HeaderText = "CCA"; // Nome da coluna para exibição
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao consultar o banco de dados: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um valor para pesquisar.");
            }
        }

        // Evento para o DataGridView (caso precise de algum tratamento)
        private void dataGridViewbat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Caso queira tratar um clique específico nas células da grid
        }
    }
}