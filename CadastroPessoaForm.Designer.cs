namespace FazendaSuinos
{
    partial class CadastroPessoaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_codigoPessoa = new System.Windows.Forms.Label();
            this.campo_codPessoa = new System.Windows.Forms.TextBox();
            this.campo_nomePessoa = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.campo_cpfPessoa = new System.Windows.Forms.TextBox();
            this.label_cpf = new System.Windows.Forms.Label();
            this.campo_telefonePessoa = new System.Windows.Forms.TextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.campo_codEmpresa = new System.Windows.Forms.TextBox();
            this.label_codEmpresa = new System.Windows.Forms.Label();
            this.label_tipovinculo = new System.Windows.Forms.Label();
            this.combo_tipovinculo = new System.Windows.Forms.ComboBox();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_alterar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_consultar = new System.Windows.Forms.Button();
            this.dataGridView_cadastroPessoa = new System.Windows.Forms.DataGridView();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazenda_suinosDataSet = new FazendaSuinos.fazenda_suinosDataSet();
            this.fazendasuinosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new FazendaSuinos.fazenda_suinosDataSetTableAdapters.PessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cadastroPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazenda_suinosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasuinosDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_codigoPessoa
            // 
            this.label_codigoPessoa.AutoSize = true;
            this.label_codigoPessoa.Location = new System.Drawing.Point(46, 42);
            this.label_codigoPessoa.Name = "label_codigoPessoa";
            this.label_codigoPessoa.Size = new System.Drawing.Size(51, 16);
            this.label_codigoPessoa.TabIndex = 0;
            this.label_codigoPessoa.Text = "Código";
            // 
            // campo_codPessoa
            // 
            this.campo_codPessoa.Location = new System.Drawing.Point(49, 62);
            this.campo_codPessoa.Name = "campo_codPessoa";
            this.campo_codPessoa.Size = new System.Drawing.Size(100, 22);
            this.campo_codPessoa.TabIndex = 1;
            // 
            // campo_nomePessoa
            // 
            this.campo_nomePessoa.Location = new System.Drawing.Point(215, 62);
            this.campo_nomePessoa.Name = "campo_nomePessoa";
            this.campo_nomePessoa.Size = new System.Drawing.Size(502, 22);
            this.campo_nomePessoa.TabIndex = 3;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(212, 43);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(44, 16);
            this.label_nome.TabIndex = 2;
            this.label_nome.Text = "Nome";
            // 
            // campo_cpfPessoa
            // 
            this.campo_cpfPessoa.Location = new System.Drawing.Point(397, 123);
            this.campo_cpfPessoa.Name = "campo_cpfPessoa";
            this.campo_cpfPessoa.Size = new System.Drawing.Size(133, 22);
            this.campo_cpfPessoa.TabIndex = 5;
            // 
            // label_cpf
            // 
            this.label_cpf.AutoSize = true;
            this.label_cpf.Location = new System.Drawing.Point(394, 103);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(33, 16);
            this.label_cpf.TabIndex = 4;
            this.label_cpf.Text = "CPF";
            // 
            // campo_telefonePessoa
            // 
            this.campo_telefonePessoa.Location = new System.Drawing.Point(584, 123);
            this.campo_telefonePessoa.Name = "campo_telefonePessoa";
            this.campo_telefonePessoa.Size = new System.Drawing.Size(133, 22);
            this.campo_telefonePessoa.TabIndex = 7;
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Location = new System.Drawing.Point(581, 103);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(61, 16);
            this.label_telefone.TabIndex = 6;
            this.label_telefone.Text = "Telefone";
            // 
            // campo_codEmpresa
            // 
            this.campo_codEmpresa.Location = new System.Drawing.Point(49, 123);
            this.campo_codEmpresa.Name = "campo_codEmpresa";
            this.campo_codEmpresa.Size = new System.Drawing.Size(100, 22);
            this.campo_codEmpresa.TabIndex = 9;
            // 
            // label_codEmpresa
            // 
            this.label_codEmpresa.AutoSize = true;
            this.label_codEmpresa.Location = new System.Drawing.Point(46, 103);
            this.label_codEmpresa.Name = "label_codEmpresa";
            this.label_codEmpresa.Size = new System.Drawing.Size(62, 16);
            this.label_codEmpresa.TabIndex = 8;
            this.label_codEmpresa.Text = "Empresa";
            // 
            // label_tipovinculo
            // 
            this.label_tipovinculo.AutoSize = true;
            this.label_tipovinculo.Location = new System.Drawing.Point(175, 103);
            this.label_tipovinculo.Name = "label_tipovinculo";
            this.label_tipovinculo.Size = new System.Drawing.Size(89, 16);
            this.label_tipovinculo.TabIndex = 10;
            this.label_tipovinculo.Text = "Tipo / Vínculo";
            // 
            // combo_tipovinculo
            // 
            this.combo_tipovinculo.FormattingEnabled = true;
            this.combo_tipovinculo.Items.AddRange(new object[] {
            "Funcionário",
            "Técnico",
            "Gerente",
            "Administrador",
            "Usuário"});
            this.combo_tipovinculo.Location = new System.Drawing.Point(178, 123);
            this.combo_tipovinculo.Name = "combo_tipovinculo";
            this.combo_tipovinculo.Size = new System.Drawing.Size(158, 24);
            this.combo_tipovinculo.TabIndex = 11;
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(49, 180);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(100, 32);
            this.button_adicionar.TabIndex = 12;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Location = new System.Drawing.Point(178, 180);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(100, 32);
            this.button_excluir.TabIndex = 13;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            // 
            // button_alterar
            // 
            this.button_alterar.Location = new System.Drawing.Point(307, 180);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(100, 32);
            this.button_alterar.TabIndex = 14;
            this.button_alterar.Text = "Alterar";
            this.button_alterar.UseVisualStyleBackColor = true;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(617, 180);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(100, 32);
            this.button_limpar.TabIndex = 15;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            // 
            // button_consultar
            // 
            this.button_consultar.Image = global::FazendaSuinos.Properties.Resources.lupa_menor;
            this.button_consultar.Location = new System.Drawing.Point(155, 58);
            this.button_consultar.Name = "button_consultar";
            this.button_consultar.Size = new System.Drawing.Size(30, 30);
            this.button_consultar.TabIndex = 16;
            this.button_consultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_cadastroPessoa
            // 
            this.dataGridView_cadastroPessoa.AutoGenerateColumns = false;
            this.dataGridView_cadastroPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cadastroPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.codempresaDataGridViewTextBoxColumn});
            this.dataGridView_cadastroPessoa.DataSource = this.pessoaBindingSource;
            this.dataGridView_cadastroPessoa.Location = new System.Drawing.Point(49, 281);
            this.dataGridView_cadastroPessoa.Name = "dataGridView_cadastroPessoa";
            this.dataGridView_cadastroPessoa.RowHeadersWidth = 51;
            this.dataGridView_cadastroPessoa.RowTemplate.Height = 24;
            this.dataGridView_cadastroPessoa.Size = new System.Drawing.Size(668, 315);
            this.dataGridView_cadastroPessoa.TabIndex = 17;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "cod";
            this.codDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.Width = 125;
            // 
            // codempresaDataGridViewTextBoxColumn
            // 
            this.codempresaDataGridViewTextBoxColumn.DataPropertyName = "cod_empresa";
            this.codempresaDataGridViewTextBoxColumn.HeaderText = "cod_empresa";
            this.codempresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codempresaDataGridViewTextBoxColumn.Name = "codempresaDataGridViewTextBoxColumn";
            this.codempresaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.fazenda_suinosDataSet;
            // 
            // fazenda_suinosDataSet
            // 
            this.fazenda_suinosDataSet.DataSetName = "fazenda_suinosDataSet";
            this.fazenda_suinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fazendasuinosDataSetBindingSource
            // 
            this.fazendasuinosDataSetBindingSource.DataSource = this.fazenda_suinosDataSet;
            this.fazendasuinosDataSetBindingSource.Position = 0;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroPessoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.dataGridView_cadastroPessoa);
            this.Controls.Add(this.button_consultar);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_alterar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.combo_tipovinculo);
            this.Controls.Add(this.label_tipovinculo);
            this.Controls.Add(this.campo_codEmpresa);
            this.Controls.Add(this.label_codEmpresa);
            this.Controls.Add(this.campo_telefonePessoa);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.campo_cpfPessoa);
            this.Controls.Add(this.label_cpf);
            this.Controls.Add(this.campo_nomePessoa);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.campo_codPessoa);
            this.Controls.Add(this.label_codigoPessoa);
            this.Name = "CadastroPessoaForm";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.CadastroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cadastroPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazenda_suinosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendasuinosDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_codigoPessoa;
        private System.Windows.Forms.TextBox campo_codPessoa;
        private System.Windows.Forms.TextBox campo_nomePessoa;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox campo_cpfPessoa;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.TextBox campo_telefonePessoa;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.TextBox campo_codEmpresa;
        private System.Windows.Forms.Label label_codEmpresa;
        private System.Windows.Forms.Label label_tipovinculo;
        private System.Windows.Forms.ComboBox combo_tipovinculo;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_consultar;
        private System.Windows.Forms.DataGridView dataGridView_cadastroPessoa;
        private System.Windows.Forms.BindingSource fazendasuinosDataSetBindingSource;
        private fazenda_suinosDataSet fazenda_suinosDataSet;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private fazenda_suinosDataSetTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codempresaDataGridViewTextBoxColumn;
    }
}