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
    public partial class CadastroPessoaForm : Form
    {
        public CadastroPessoaForm()
        {
            InitializeComponent();
        }

        private void CadastroForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazenda_suinosDataSet.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.fazenda_suinosDataSet.Pessoa);

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
                "INSERT INTO Pessoa (Nome, Telefone, CPF, Cod_Empresa) " +
                "VALUES (@Nome, @Telefone, @CPF, @Cod_Empresa)", conn);

            //Atribui valor aos parâmetros
            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = 0;

            comm.Parameters.Add("@Nome", System.Data.SqlDbType.VarChar, 50);
            comm.Parameters["@Nome"].Value = campo_nomePessoa.Text;

            comm.Parameters.Add("@Telefone", System.Data.SqlDbType.VarChar, 11);
            comm.Parameters["@Telefone"].Value = campo_telefonePessoa.Text;

            comm.Parameters.Add("@CPF", System.Data.SqlDbType.VarChar, 14);
            comm.Parameters["@CPF"].Value = campo_cpfPessoa.Text;

            comm.Parameters.Add("@Cod_Empresa", System.Data.SqlDbType.Int);
            comm.Parameters["@Cod_Empresa"].Value = Convert.ToInt32(campo_codEmpresa.Text);

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
                    //Chama função que atualiza os dados no DataGridView
                    MessageBox.Show(
                        "Registro Cadastrado!",
                        "Banco de Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Reinicia campos de texto
                    campo_codPessoa.Text = "";
                    campo_nomePessoa.Text = "";
                    campo_telefonePessoa.Text = "";
                    campo_cpfPessoa.Text = "";
                    campo_codEmpresa.Text = "";

                    campo_codPessoa.Focus();
                }
            }
        } //Fim do evento de clique do botão Adicionar
    }
}
