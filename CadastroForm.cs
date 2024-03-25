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
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void CadastroForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazenda_suinosDataSet.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.fazenda_suinosDataSet.Pessoa);

        }
    }
}
