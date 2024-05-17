﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace fazendaSuinos
{
    public partial class FormMedicacao : Form
    {
        private string connectionString = Properties.Settings.Default.fazendaSuinosConnectionString;
        public FormMedicacao()
        {
            InitializeComponent();
            pcbMeicamentos.Visible = false;
        }

        private void LoadLote()
        {
            using (DatabaseConnection connection = new DatabaseConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string querySelecao = "SELECT * FROM Lote";

                    // Cria um adaptador de dados para executar a query
                    SqlDataAdapter adapter = new SqlDataAdapter(querySelecao, connectionString);

                    // Cria um DataTable para armazenar os resultados
                    DataTable dataTable = new DataTable();

                    // Preenche o DataTable com os resultados da consulta
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridViewLote.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar objeto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void SalvarDados()
        {
            try
            {
                // Obtém os valores dos controles
                string Medicacao = txtMedicamento.SelectedItem.ToString();
                int Quantidade = Convert.ToInt32(txtQntVac.Text);
                DateTime Data_Inicial = dtpVacinacao.Value;
                int Dias_Uso = Convert.ToInt32(txtDiasUso.Text);
                int Dias_Carencia = Convert.ToInt32(txtDiasCarencia.Text);
                string Observacao = txtObservacao.Text;
                int CodLote = Convert.ToInt32(txtCodigoLote.Text);

                // Abre a conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Cria o comando SQL para inserir os dados na tabela
                    string queryInsercao = "INSERT INTO Controle_Vacinacao (Medicacao,Quantidade,Data_Inicial,Dias_Uso,Dias_Carencia,Observacao,CodLote) VALUES (@Medicacao,@Quantidade,@Data_Inicial,@Dias_Uso,@Dias_Carencia,@Observacao,@CodLote)";
                    SqlCommand command = new SqlCommand(queryInsercao, connection);

                    // Adiciona os parâmetros ao comando SQL
                    command.Parameters.AddWithValue("@Medicacao", Medicacao);
                    command.Parameters.AddWithValue("@Quantidade", Quantidade);
                    command.Parameters.AddWithValue("@Data_Inicial", Data_Inicial);
                    command.Parameters.AddWithValue("@Dias_Uso", Dias_Uso);
                    command.Parameters.AddWithValue("@Dias_Carencia", Dias_Carencia);
                    command.Parameters.AddWithValue("@Observacao", Observacao);
                    command.Parameters.AddWithValue("@CodLote", CodLote);

                    // Executa o comando SQL
                    command.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMedicacao_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarCodigoLote_Click(object sender, EventArgs e)
        {
            LoadLote();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDados();
        }

        private void btnConsultarCarencia_Click(object sender, EventArgs e)
        {
            pcbMeicamentos.Visible = true;
        }
    }
}