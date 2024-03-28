namespace FazendaSuinos
{
    partial class CadastroEmpresaForm
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
            this.dataGridView_cadastroEmpresa = new System.Windows.Forms.DataGridView();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaosocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazenda_suinosDataSet = new FazendaSuinos.fazenda_suinosDataSet();
            this.button_consultar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_alterar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.campo_cepEmpresa = new System.Windows.Forms.TextBox();
            this.label_codEmpresa = new System.Windows.Forms.Label();
            this.campo_telefoneEmpresa = new System.Windows.Forms.TextBox();
            this.label_telefoneEmpresa = new System.Windows.Forms.Label();
            this.campo_cnpjEmpresa = new System.Windows.Forms.TextBox();
            this.label_cnpjEmpresa = new System.Windows.Forms.Label();
            this.campo_razaoSocial = new System.Windows.Forms.TextBox();
            this.label_razaoSocial = new System.Windows.Forms.Label();
            this.campo_codEmpresa = new System.Windows.Forms.TextBox();
            this.label_codigoEmpresa = new System.Windows.Forms.Label();
            this.combo_tipovinculo = new System.Windows.Forms.ComboBox();
            this.label_tipoEmpresa = new System.Windows.Forms.Label();
            this.empresaTableAdapter = new FazendaSuinos.fazenda_suinosDataSetTableAdapters.EmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cadastroEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazenda_suinosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cadastroEmpresa
            // 
            this.dataGridView_cadastroEmpresa.AutoGenerateColumns = false;
            this.dataGridView_cadastroEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cadastroEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.razaosocialDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView_cadastroEmpresa.DataSource = this.empresaBindingSource;
            this.dataGridView_cadastroEmpresa.Location = new System.Drawing.Point(60, 298);
            this.dataGridView_cadastroEmpresa.Name = "dataGridView_cadastroEmpresa";
            this.dataGridView_cadastroEmpresa.RowHeadersWidth = 51;
            this.dataGridView_cadastroEmpresa.RowTemplate.Height = 24;
            this.dataGridView_cadastroEmpresa.Size = new System.Drawing.Size(678, 315);
            this.dataGridView_cadastroEmpresa.TabIndex = 35;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "cod";
            this.codDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.Width = 125;
            // 
            // razaosocialDataGridViewTextBoxColumn
            // 
            this.razaosocialDataGridViewTextBoxColumn.DataPropertyName = "razao_social";
            this.razaosocialDataGridViewTextBoxColumn.HeaderText = "razao_social";
            this.razaosocialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razaosocialDataGridViewTextBoxColumn.Name = "razaosocialDataGridViewTextBoxColumn";
            this.razaosocialDataGridViewTextBoxColumn.Width = 125;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.fazenda_suinosDataSet;
            // 
            // fazenda_suinosDataSet
            // 
            this.fazenda_suinosDataSet.DataSetName = "fazenda_suinosDataSet";
            this.fazenda_suinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_consultar
            // 
            this.button_consultar.Image = global::FazendaSuinos.Properties.Resources.lupa_menor;
            this.button_consultar.Location = new System.Drawing.Point(176, 75);
            this.button_consultar.Name = "button_consultar";
            this.button_consultar.Size = new System.Drawing.Size(30, 30);
            this.button_consultar.TabIndex = 34;
            this.button_consultar.UseVisualStyleBackColor = true;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(638, 197);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(100, 32);
            this.button_limpar.TabIndex = 33;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            // 
            // button_alterar
            // 
            this.button_alterar.Location = new System.Drawing.Point(328, 197);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(100, 32);
            this.button_alterar.TabIndex = 32;
            this.button_alterar.Text = "Alterar";
            this.button_alterar.UseVisualStyleBackColor = true;
            // 
            // button_excluir
            // 
            this.button_excluir.Location = new System.Drawing.Point(199, 197);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(100, 32);
            this.button_excluir.TabIndex = 31;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(70, 197);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(100, 32);
            this.button_adicionar.TabIndex = 30;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // campo_cepEmpresa
            // 
            this.campo_cepEmpresa.Location = new System.Drawing.Point(70, 140);
            this.campo_cepEmpresa.Name = "campo_cepEmpresa";
            this.campo_cepEmpresa.Size = new System.Drawing.Size(100, 22);
            this.campo_cepEmpresa.TabIndex = 27;
            // 
            // label_codEmpresa
            // 
            this.label_codEmpresa.AutoSize = true;
            this.label_codEmpresa.Location = new System.Drawing.Point(67, 120);
            this.label_codEmpresa.Name = "label_codEmpresa";
            this.label_codEmpresa.Size = new System.Drawing.Size(34, 16);
            this.label_codEmpresa.TabIndex = 26;
            this.label_codEmpresa.Text = "CEP";
            // 
            // campo_telefoneEmpresa
            // 
            this.campo_telefoneEmpresa.Location = new System.Drawing.Point(605, 140);
            this.campo_telefoneEmpresa.Name = "campo_telefoneEmpresa";
            this.campo_telefoneEmpresa.Size = new System.Drawing.Size(133, 22);
            this.campo_telefoneEmpresa.TabIndex = 25;
            // 
            // label_telefoneEmpresa
            // 
            this.label_telefoneEmpresa.AutoSize = true;
            this.label_telefoneEmpresa.Location = new System.Drawing.Point(602, 120);
            this.label_telefoneEmpresa.Name = "label_telefoneEmpresa";
            this.label_telefoneEmpresa.Size = new System.Drawing.Size(61, 16);
            this.label_telefoneEmpresa.TabIndex = 24;
            this.label_telefoneEmpresa.Text = "Telefone";
            // 
            // campo_cnpjEmpresa
            // 
            this.campo_cnpjEmpresa.Location = new System.Drawing.Point(398, 140);
            this.campo_cnpjEmpresa.Name = "campo_cnpjEmpresa";
            this.campo_cnpjEmpresa.Size = new System.Drawing.Size(153, 22);
            this.campo_cnpjEmpresa.TabIndex = 23;
            // 
            // label_cnpjEmpresa
            // 
            this.label_cnpjEmpresa.AutoSize = true;
            this.label_cnpjEmpresa.Location = new System.Drawing.Point(395, 120);
            this.label_cnpjEmpresa.Name = "label_cnpjEmpresa";
            this.label_cnpjEmpresa.Size = new System.Drawing.Size(42, 16);
            this.label_cnpjEmpresa.TabIndex = 22;
            this.label_cnpjEmpresa.Text = "CNPJ";
            // 
            // campo_razaoSocial
            // 
            this.campo_razaoSocial.Location = new System.Drawing.Point(236, 79);
            this.campo_razaoSocial.Name = "campo_razaoSocial";
            this.campo_razaoSocial.Size = new System.Drawing.Size(502, 22);
            this.campo_razaoSocial.TabIndex = 21;
            // 
            // label_razaoSocial
            // 
            this.label_razaoSocial.AutoSize = true;
            this.label_razaoSocial.Location = new System.Drawing.Point(233, 60);
            this.label_razaoSocial.Name = "label_razaoSocial";
            this.label_razaoSocial.Size = new System.Drawing.Size(88, 16);
            this.label_razaoSocial.TabIndex = 20;
            this.label_razaoSocial.Text = "Razão Social";
            // 
            // campo_codEmpresa
            // 
            this.campo_codEmpresa.Location = new System.Drawing.Point(70, 79);
            this.campo_codEmpresa.Name = "campo_codEmpresa";
            this.campo_codEmpresa.Size = new System.Drawing.Size(100, 22);
            this.campo_codEmpresa.TabIndex = 19;
            // 
            // label_codigoEmpresa
            // 
            this.label_codigoEmpresa.AutoSize = true;
            this.label_codigoEmpresa.Location = new System.Drawing.Point(67, 59);
            this.label_codigoEmpresa.Name = "label_codigoEmpresa";
            this.label_codigoEmpresa.Size = new System.Drawing.Size(51, 16);
            this.label_codigoEmpresa.TabIndex = 18;
            this.label_codigoEmpresa.Text = "Código";
            // 
            // combo_tipovinculo
            // 
            this.combo_tipovinculo.FormattingEnabled = true;
            this.combo_tipovinculo.Items.AddRange(new object[] {
            "Produtor",
            "Fornecedor"});
            this.combo_tipovinculo.Location = new System.Drawing.Point(199, 138);
            this.combo_tipovinculo.Name = "combo_tipovinculo";
            this.combo_tipovinculo.Size = new System.Drawing.Size(158, 24);
            this.combo_tipovinculo.TabIndex = 37;
            // 
            // label_tipoEmpresa
            // 
            this.label_tipoEmpresa.AutoSize = true;
            this.label_tipoEmpresa.Location = new System.Drawing.Point(196, 118);
            this.label_tipoEmpresa.Name = "label_tipoEmpresa";
            this.label_tipoEmpresa.Size = new System.Drawing.Size(35, 16);
            this.label_tipoEmpresa.TabIndex = 36;
            this.label_tipoEmpresa.Text = "Tipo";
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroEmpresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 673);
            this.Controls.Add(this.combo_tipovinculo);
            this.Controls.Add(this.label_tipoEmpresa);
            this.Controls.Add(this.dataGridView_cadastroEmpresa);
            this.Controls.Add(this.button_consultar);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_alterar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.campo_cepEmpresa);
            this.Controls.Add(this.label_codEmpresa);
            this.Controls.Add(this.campo_telefoneEmpresa);
            this.Controls.Add(this.label_telefoneEmpresa);
            this.Controls.Add(this.campo_cnpjEmpresa);
            this.Controls.Add(this.label_cnpjEmpresa);
            this.Controls.Add(this.campo_razaoSocial);
            this.Controls.Add(this.label_razaoSocial);
            this.Controls.Add(this.campo_codEmpresa);
            this.Controls.Add(this.label_codigoEmpresa);
            this.Name = "CadastroEmpresaForm";
            this.Text = "Cadastro de Empresas";
            this.Load += new System.EventHandler(this.CadastroEmpresaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cadastroEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazenda_suinosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cadastroEmpresa;
        private System.Windows.Forms.Button button_consultar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.TextBox campo_cepEmpresa;
        private System.Windows.Forms.Label label_codEmpresa;
        private System.Windows.Forms.TextBox campo_telefoneEmpresa;
        private System.Windows.Forms.Label label_telefoneEmpresa;
        private System.Windows.Forms.TextBox campo_cnpjEmpresa;
        private System.Windows.Forms.Label label_cnpjEmpresa;
        private System.Windows.Forms.TextBox campo_razaoSocial;
        private System.Windows.Forms.Label label_razaoSocial;
        private System.Windows.Forms.TextBox campo_codEmpresa;
        private System.Windows.Forms.Label label_codigoEmpresa;
        private System.Windows.Forms.ComboBox combo_tipovinculo;
        private System.Windows.Forms.Label label_tipoEmpresa;
        private fazenda_suinosDataSet fazenda_suinosDataSet;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private fazenda_suinosDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaosocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}