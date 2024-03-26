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
            // Instanciar o novo formulário
            CadastroForm cadastroFormulario = new CadastroForm();

            // Exibir o novo formulário
            cadastroFormulario.Show();
        }
    }
}
