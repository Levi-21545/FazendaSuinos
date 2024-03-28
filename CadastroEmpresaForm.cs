using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaSuinos
{
    public partial class CadastroEmpresaForm : Form
    {
        public CadastroEmpresaForm()
        {
            InitializeComponent();
        }

        private void CadastroEmpresaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazenda_suinosDataSet.Empresa'. Você pode movê-la ou removê-la conforme necessário.
            this.empresaTableAdapter.Fill(this.fazenda_suinosDataSet.Empresa);

        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool bIsOperationOK = true;

            //Lê a String que representa os dados da conexão contidos no app.config
            string connectionString = Properties.Settings.Default.fazenda_suinosConnectionString;

            //Inicializa a conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            //Cria o comando SQL para a inclusão de dados na tabela
            comm = new SqlCommand(
                "INSERT INTO Empresa (Razao_Social, CNPJ, Telefone, CEP) " +
                "VALUES (@Razao_Social, @CNPJ, @Telefone, @CEP)", conn);

            //Atribui valor aos parâmetros
            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = 0;

            comm.Parameters.Add("@Razao_Social", System.Data.SqlDbType.VarChar, 70);
            comm.Parameters["@Razao_Social"].Value = campo_razaoSocial.Text;

            comm.Parameters.Add("@Telefone", System.Data.SqlDbType.VarChar, 11);
            comm.Parameters["@Telefone"].Value = campo_telefoneEmpresa.Text;

            comm.Parameters.Add("@CNPJ", System.Data.SqlDbType.VarChar, 18);
            comm.Parameters["@CNPJ"].Value = campo_cnpjEmpresa.Text;

            comm.Parameters.Add("@CEP", System.Data.SqlDbType.VarChar, 8);
            comm.Parameters["@CEP"].Value = campo_cepEmpresa.Text;

            //Usa tratamento de exceção para se certificar que a operação foi
            //bem executada. Senão, exibe mensagens de erro ao usuário
            try
            {
                try
                {
                    //Abre conexão com o BD
                    conn.Open();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(
                        error.Message,
                        "Erro ao abrir conexão com o banco de dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    //Executa comando SQL
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bIsOperationOK = false;
                    MessageBox.Show(
                        error.Message,
                        "Erro ao executar comando SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                //Fecha conexão com o BD
                conn.Close();

                if (bIsOperationOK)
                {
                    MessageBox.Show(
                        "Registro Cadastrado!",
                        "Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    dataGridView_cadastroEmpresa.Invalidate();

                    //Reinicia campos de texto
                    campo_razaoSocial.Text = "";
                    campo_codEmpresa.Text = "";
                    campo_cepEmpresa.Text = "";
                    campo_cnpjEmpresa.Text = "";
                    campo_telefoneEmpresa.Text = "";

                    campo_codEmpresa.Focus();
                }
            }
        }
    }
}
