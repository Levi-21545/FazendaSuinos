using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaSuinos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verificar se o formulário ja está aberto
            CadastroPessoaForm formularioExistente = Application.OpenForms.OfType<CadastroPessoaForm>().FirstOrDefault();

            //Se a variável não for nula, ele existe, então apenas mostrar
            if (formularioExistente != null)
            {
                formularioExistente.Focus();
            }
            else
            {
                // Instanciar o novo formulário
                CadastroPessoaForm cadastroFormulario = new CadastroPessoaForm();

                // Exibir o novo formulário
                cadastroFormulario.Show();
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verificar se o formulário ja está aberto
            CadastroEmpresaForm formularioExistente = Application.OpenForms.OfType<CadastroEmpresaForm>().FirstOrDefault();

            //Se a variável não for nula, ele existe, então apenas mostrar
            if (formularioExistente != null)
            {
                formularioExistente.Focus();
            }
            else
            {
                // Instanciar o novo formulário
                CadastroEmpresaForm cadastroFormulario = new CadastroEmpresaForm();

                // Exibir o novo formulário
                cadastroFormulario.Show();
            }

        }
    }
}
