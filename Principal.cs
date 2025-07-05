using baterias.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baterias
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.FormClosing += Principal_FormClosing;
        }

        //fechar a aplicação
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
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

            try
            {
                SearchRepository repo = new SearchRepository();
                DataTable dt = repo.SearchData(txtBat.Text);
                dataGridViewbat.DataSource = dt;

                dataGridViewbat.Columns["Carro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewbat.Columns["CCA"].HeaderText = "CCA";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao consultar o banco de dados: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}