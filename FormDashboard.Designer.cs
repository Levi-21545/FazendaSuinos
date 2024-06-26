﻿namespace fazendaSuinos
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.panelConsRação = new System.Windows.Forms.Panel();
            this.chartConsumo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboLoteCons = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelAcoesCorretivas = new System.Windows.Forms.Panel();
            this.comboCodProp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.campoQuant = new System.Windows.Forms.TextBox();
            this.campoLotesAbertos = new System.Windows.Forms.TextBox();
            this.campoLotes = new System.Windows.Forms.TextBox();
            this.campoPocilgas = new System.Windows.Forms.TextBox();
            this.campoNomeProd = new System.Windows.Forms.TextBox();
            this.campoNomeProp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDashAcoes = new System.Windows.Forms.Label();
            this.panelDetalhesLote = new System.Windows.Forms.Panel();
            this.comboCodLote_Det = new System.Windows.Forms.ComboBox();
            this.campoDetCodGerente = new System.Windows.Forms.TextBox();
            this.campoDetDataCarreg = new System.Windows.Forms.TextBox();
            this.campoDetDataAloj = new System.Windows.Forms.TextBox();
            this.campoDetSituacao = new System.Windows.Forms.TextBox();
            this.campoDetPesoMedio = new System.Windows.Forms.TextBox();
            this.campoDetPesoTotal = new System.Windows.Forms.TextBox();
            this.campoDetQuant = new System.Windows.Forms.TextBox();
            this.labelDetCodGerente = new System.Windows.Forms.Label();
            this.labelDetDataCarreg = new System.Windows.Forms.Label();
            this.labelDetDataAloj = new System.Windows.Forms.Label();
            this.labelDetSituacao = new System.Windows.Forms.Label();
            this.labelDetPesoMedio = new System.Windows.Forms.Label();
            this.labelDetPesoTotal = new System.Windows.Forms.Label();
            this.labelDetQuant = new System.Windows.Forms.Label();
            this.labelDetCod = new System.Windows.Forms.Label();
            this.labelDashDetalhes = new System.Windows.Forms.Label();
            this.panelAgenda = new System.Windows.Forms.Panel();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnAtualizarAgenda = new FontAwesome.Sharp.IconButton();
            this.dataGridAgenda = new System.Windows.Forms.DataGridView();
            this.finalizadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codAtividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVacinacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codRacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMortalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVisitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaSuinosDataSet = new fazendaSuinos.fazendaSuinosDataSet();
            this.labelDashHoje = new System.Windows.Forms.Label();
            this.agendaTableAdapter = new fazendaSuinos.fazendaSuinosDataSetTableAdapters.AgendaTableAdapter();
            this.contextMenuStripAgenda = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ocultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDashboard.SuspendLayout();
            this.panelConsRação.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).BeginInit();
            this.panelAcoesCorretivas.SuspendLayout();
            this.panelDetalhesLote.SuspendLayout();
            this.panelAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).BeginInit();
            this.contextMenuStripAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.panelConsRação);
            this.panelDashboard.Controls.Add(this.panelAcoesCorretivas);
            this.panelDashboard.Controls.Add(this.panelDetalhesLote);
            this.panelDashboard.Controls.Add(this.panelAgenda);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1765, 992);
            this.panelDashboard.TabIndex = 0;
            // 
            // panelConsRação
            // 
            this.panelConsRação.BackColor = System.Drawing.Color.LightGray;
            this.panelConsRação.Controls.Add(this.chartConsumo);
            this.panelConsRação.Controls.Add(this.comboLoteCons);
            this.panelConsRação.Controls.Add(this.label1);
            this.panelConsRação.Controls.Add(this.label15);
            this.panelConsRação.Location = new System.Drawing.Point(113, 527);
            this.panelConsRação.Margin = new System.Windows.Forms.Padding(4);
            this.panelConsRação.Name = "panelConsRação";
            this.panelConsRação.Size = new System.Drawing.Size(661, 377);
            this.panelConsRação.TabIndex = 34;
            // 
            // chartConsumo
            // 
            this.chartConsumo.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartConsumo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend3";
            this.chartConsumo.Legends.Add(legend1);
            this.chartConsumo.Location = new System.Drawing.Point(20, 103);
            this.chartConsumo.Margin = new System.Windows.Forms.Padding(4);
            this.chartConsumo.Name = "chartConsumo";
            this.chartConsumo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend3";
            series1.Name = "Consumo de Ração";
            this.chartConsumo.Series.Add(series1);
            this.chartConsumo.Size = new System.Drawing.Size(609, 255);
            this.chartConsumo.TabIndex = 68;
            this.chartConsumo.Text = "Gráfico de Consumo";
            // 
            // comboLoteCons
            // 
            this.comboLoteCons.FormattingEnabled = true;
            this.comboLoteCons.Location = new System.Drawing.Point(512, 59);
            this.comboLoteCons.Margin = new System.Windows.Forms.Padding(4);
            this.comboLoteCons.Name = "comboLoteCons";
            this.comboLoteCons.Size = new System.Drawing.Size(100, 24);
            this.comboLoteCons.TabIndex = 33;
            this.comboLoteCons.SelectedIndexChanged += new System.EventHandler(this.comboLoteCons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(453, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Lote:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(47, 39);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 46);
            this.label15.TabIndex = 1;
            this.label15.Text = "Cons. Ração";
            // 
            // panelAcoesCorretivas
            // 
            this.panelAcoesCorretivas.BackColor = System.Drawing.Color.LightGray;
            this.panelAcoesCorretivas.Controls.Add(this.comboCodProp);
            this.panelAcoesCorretivas.Controls.Add(this.label8);
            this.panelAcoesCorretivas.Controls.Add(this.campoQuant);
            this.panelAcoesCorretivas.Controls.Add(this.campoLotesAbertos);
            this.panelAcoesCorretivas.Controls.Add(this.campoLotes);
            this.panelAcoesCorretivas.Controls.Add(this.campoPocilgas);
            this.panelAcoesCorretivas.Controls.Add(this.campoNomeProd);
            this.panelAcoesCorretivas.Controls.Add(this.campoNomeProp);
            this.panelAcoesCorretivas.Controls.Add(this.label2);
            this.panelAcoesCorretivas.Controls.Add(this.label3);
            this.panelAcoesCorretivas.Controls.Add(this.label4);
            this.panelAcoesCorretivas.Controls.Add(this.label5);
            this.panelAcoesCorretivas.Controls.Add(this.label6);
            this.panelAcoesCorretivas.Controls.Add(this.label7);
            this.panelAcoesCorretivas.Controls.Add(this.labelDashAcoes);
            this.panelAcoesCorretivas.Location = new System.Drawing.Point(843, 527);
            this.panelAcoesCorretivas.Margin = new System.Windows.Forms.Padding(4);
            this.panelAcoesCorretivas.Name = "panelAcoesCorretivas";
            this.panelAcoesCorretivas.Size = new System.Drawing.Size(661, 377);
            this.panelAcoesCorretivas.TabIndex = 2;
            // 
            // comboCodProp
            // 
            this.comboCodProp.FormattingEnabled = true;
            this.comboCodProp.Location = new System.Drawing.Point(503, 58);
            this.comboCodProp.Margin = new System.Windows.Forms.Padding(4);
            this.comboCodProp.Name = "comboCodProp";
            this.comboCodProp.Size = new System.Drawing.Size(100, 24);
            this.comboCodProp.TabIndex = 33;
            this.comboCodProp.SelectedIndexChanged += new System.EventHandler(this.comboCodProp_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(415, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Código:";
            // 
            // campoQuant
            // 
            this.campoQuant.BackColor = System.Drawing.Color.White;
            this.campoQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoQuant.Location = new System.Drawing.Point(372, 290);
            this.campoQuant.Margin = new System.Windows.Forms.Padding(4);
            this.campoQuant.Name = "campoQuant";
            this.campoQuant.ReadOnly = true;
            this.campoQuant.Size = new System.Drawing.Size(232, 23);
            this.campoQuant.TabIndex = 30;
            this.campoQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoLotesAbertos
            // 
            this.campoLotesAbertos.BackColor = System.Drawing.Color.White;
            this.campoLotesAbertos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoLotesAbertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoLotesAbertos.Location = new System.Drawing.Point(372, 256);
            this.campoLotesAbertos.Margin = new System.Windows.Forms.Padding(4);
            this.campoLotesAbertos.Name = "campoLotesAbertos";
            this.campoLotesAbertos.ReadOnly = true;
            this.campoLotesAbertos.Size = new System.Drawing.Size(232, 23);
            this.campoLotesAbertos.TabIndex = 29;
            this.campoLotesAbertos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoLotes
            // 
            this.campoLotes.BackColor = System.Drawing.Color.White;
            this.campoLotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoLotes.Location = new System.Drawing.Point(372, 222);
            this.campoLotes.Margin = new System.Windows.Forms.Padding(4);
            this.campoLotes.Name = "campoLotes";
            this.campoLotes.ReadOnly = true;
            this.campoLotes.Size = new System.Drawing.Size(232, 23);
            this.campoLotes.TabIndex = 28;
            this.campoLotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoPocilgas
            // 
            this.campoPocilgas.BackColor = System.Drawing.Color.White;
            this.campoPocilgas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoPocilgas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoPocilgas.Location = new System.Drawing.Point(372, 187);
            this.campoPocilgas.Margin = new System.Windows.Forms.Padding(4);
            this.campoPocilgas.Name = "campoPocilgas";
            this.campoPocilgas.ReadOnly = true;
            this.campoPocilgas.Size = new System.Drawing.Size(232, 23);
            this.campoPocilgas.TabIndex = 27;
            this.campoPocilgas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoNomeProd
            // 
            this.campoNomeProd.BackColor = System.Drawing.Color.White;
            this.campoNomeProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoNomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoNomeProd.Location = new System.Drawing.Point(372, 153);
            this.campoNomeProd.Margin = new System.Windows.Forms.Padding(4);
            this.campoNomeProd.Name = "campoNomeProd";
            this.campoNomeProd.ReadOnly = true;
            this.campoNomeProd.Size = new System.Drawing.Size(232, 23);
            this.campoNomeProd.TabIndex = 26;
            this.campoNomeProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoNomeProp
            // 
            this.campoNomeProp.BackColor = System.Drawing.Color.White;
            this.campoNomeProp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoNomeProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoNomeProp.Location = new System.Drawing.Point(372, 117);
            this.campoNomeProp.Margin = new System.Windows.Forms.Padding(4);
            this.campoNomeProp.Name = "campoNomeProp";
            this.campoNomeProp.ReadOnly = true;
            this.campoNomeProp.Size = new System.Drawing.Size(232, 23);
            this.campoNomeProp.TabIndex = 25;
            this.campoNomeProp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(63, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quantidade de Suínos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(63, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Lotes Abertos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(63, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lotes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(63, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pocilgas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(63, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Produtor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(63, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nome:";
            // 
            // labelDashAcoes
            // 
            this.labelDashAcoes.AutoSize = true;
            this.labelDashAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashAcoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDashAcoes.Location = new System.Drawing.Point(47, 39);
            this.labelDashAcoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDashAcoes.Name = "labelDashAcoes";
            this.labelDashAcoes.Size = new System.Drawing.Size(269, 46);
            this.labelDashAcoes.TabIndex = 1;
            this.labelDashAcoes.Text = "Propriedades";
            // 
            // panelDetalhesLote
            // 
            this.panelDetalhesLote.BackColor = System.Drawing.Color.LightGray;
            this.panelDetalhesLote.Controls.Add(this.comboCodLote_Det);
            this.panelDetalhesLote.Controls.Add(this.campoDetCodGerente);
            this.panelDetalhesLote.Controls.Add(this.campoDetDataCarreg);
            this.panelDetalhesLote.Controls.Add(this.campoDetDataAloj);
            this.panelDetalhesLote.Controls.Add(this.campoDetSituacao);
            this.panelDetalhesLote.Controls.Add(this.campoDetPesoMedio);
            this.panelDetalhesLote.Controls.Add(this.campoDetPesoTotal);
            this.panelDetalhesLote.Controls.Add(this.campoDetQuant);
            this.panelDetalhesLote.Controls.Add(this.labelDetCodGerente);
            this.panelDetalhesLote.Controls.Add(this.labelDetDataCarreg);
            this.panelDetalhesLote.Controls.Add(this.labelDetDataAloj);
            this.panelDetalhesLote.Controls.Add(this.labelDetSituacao);
            this.panelDetalhesLote.Controls.Add(this.labelDetPesoMedio);
            this.panelDetalhesLote.Controls.Add(this.labelDetPesoTotal);
            this.panelDetalhesLote.Controls.Add(this.labelDetQuant);
            this.panelDetalhesLote.Controls.Add(this.labelDetCod);
            this.panelDetalhesLote.Controls.Add(this.labelDashDetalhes);
            this.panelDetalhesLote.Location = new System.Drawing.Point(843, 80);
            this.panelDetalhesLote.Margin = new System.Windows.Forms.Padding(4);
            this.panelDetalhesLote.Name = "panelDetalhesLote";
            this.panelDetalhesLote.Size = new System.Drawing.Size(661, 389);
            this.panelDetalhesLote.TabIndex = 1;
            // 
            // comboCodLote_Det
            // 
            this.comboCodLote_Det.FormattingEnabled = true;
            this.comboCodLote_Det.Location = new System.Drawing.Point(503, 43);
            this.comboCodLote_Det.Margin = new System.Windows.Forms.Padding(4);
            this.comboCodLote_Det.Name = "comboCodLote_Det";
            this.comboCodLote_Det.Size = new System.Drawing.Size(100, 24);
            this.comboCodLote_Det.TabIndex = 19;
            this.comboCodLote_Det.SelectedIndexChanged += new System.EventHandler(this.comboCodLote_Det_SelectedIndexChanged);
            this.comboCodLote_Det.TextUpdate += new System.EventHandler(this.comboCodLote_Det_SelectedIndexChanged);
            // 
            // campoDetCodGerente
            // 
            this.campoDetCodGerente.BackColor = System.Drawing.Color.White;
            this.campoDetCodGerente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoDetCodGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoDetCodGerente.Location = new System.Drawing.Point(372, 311);
            this.campoDetCodGerente.Margin = new System.Windows.Forms.Padding(4);
            this.campoDetCodGerente.Name = "campoDetCodGerente";
            this.campoDetCodGerente.ReadOnly = true;
            this.campoDetCodGerente.Size = new System.Drawing.Size(232, 23);
            this.campoDetCodGerente.TabIndex = 17;
            this.campoDetCodGerente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoDetDataCarreg
            // 
            this.campoDetDataCarreg.BackColor = System.Drawing.Color.White;
            this.campoDetDataCarreg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoDetDataCarreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoDetDataCarreg.Location = new System.Drawing.Point(372, 277);
            this.campoDetDataCarreg.Margin = new System.Windows.Forms.Padding(4);
            this.campoDetDataCarreg.Name = "campoDetDataCarreg";
            this.campoDetDataCarreg.ReadOnly = true;
            this.campoDetDataCarreg.Size = new System.Drawing.Size(232, 23);
            this.campoDetDataCarreg.TabIndex = 16;
            this.campoDetDataCarreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoDetDataAloj
            // 
            this.campoDetDataAloj.BackColor = System.Drawing.Color.White;
            this.campoDetDataAloj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoDetDataAloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoDetDataAloj.Location = new System.Drawing.Point(372, 242);
            this.campoDetDataAloj.Margin = new System.Windows.Forms.Padding(4);
            this.campoDetDataAloj.Name = "campoDetDataAloj";
            this.campoDetDataAloj.ReadOnly = true;
            this.campoDetDataAloj.Size = new System.Drawing.Size(232, 23);
            this.campoDetDataAloj.TabIndex = 15;
            this.campoDetDataAloj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoDetSituacao
            // 
            this.campoDetSituacao.BackColor = System.Drawing.Color.White;
            this.campoDetSituacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoDetSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoDetSituacao.Location = new System.Drawing.Point(372, 208);
            this.campoDetSituacao.Margin = new System.Windows.Forms.Padding(4);
            this.campoDetSituacao.Name = "campoDetSituacao";
            this.campoDetSituacao.ReadOnly = true;
            this.campoDetSituacao.Size = new System.Drawing.Size(232, 23);
            this.campoDetSituacao.TabIndex = 14;
            this.campoDetSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoDetPesoMedio
            // 
            this.campoDetPesoMedio.BackColor = System.Drawing.Color.White;
            this.campoDetPesoMedio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoDetPesoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoDetPesoMedio.Location = new System.Drawing.Point(372, 174);
            this.campoDetPesoMedio.Margin = new System.Windows.Forms.Padding(4);
            this.campoDetPesoMedio.Name = "campoDetPesoMedio";
            this.campoDetPesoMedio.ReadOnly = true;
            this.campoDetPesoMedio.Size = new System.Drawing.Size(232, 23);
            this.campoDetPesoMedio.TabIndex = 13;
            this.campoDetPesoMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoDetPesoTotal
            // 
            this.campoDetPesoTotal.BackColor = System.Drawing.Color.White;
            this.campoDetPesoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoDetPesoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoDetPesoTotal.Location = new System.Drawing.Point(372, 139);
            this.campoDetPesoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.campoDetPesoTotal.Name = "campoDetPesoTotal";
            this.campoDetPesoTotal.ReadOnly = true;
            this.campoDetPesoTotal.Size = new System.Drawing.Size(232, 23);
            this.campoDetPesoTotal.TabIndex = 12;
            this.campoDetPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // campoDetQuant
            // 
            this.campoDetQuant.BackColor = System.Drawing.Color.White;
            this.campoDetQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campoDetQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.campoDetQuant.Location = new System.Drawing.Point(372, 103);
            this.campoDetQuant.Margin = new System.Windows.Forms.Padding(4);
            this.campoDetQuant.Name = "campoDetQuant";
            this.campoDetQuant.ReadOnly = true;
            this.campoDetQuant.Size = new System.Drawing.Size(232, 23);
            this.campoDetQuant.TabIndex = 11;
            this.campoDetQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDetCodGerente
            // 
            this.labelDetCodGerente.AutoSize = true;
            this.labelDetCodGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDetCodGerente.Location = new System.Drawing.Point(63, 311);
            this.labelDetCodGerente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetCodGerente.Name = "labelDetCodGerente";
            this.labelDetCodGerente.Size = new System.Drawing.Size(176, 24);
            this.labelDetCodGerente.TabIndex = 9;
            this.labelDetCodGerente.Text = "Código do Gerente:";
            // 
            // labelDetDataCarreg
            // 
            this.labelDetDataCarreg.AutoSize = true;
            this.labelDetDataCarreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDetDataCarreg.Location = new System.Drawing.Point(63, 277);
            this.labelDetDataCarreg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetDataCarreg.Name = "labelDetDataCarreg";
            this.labelDetDataCarreg.Size = new System.Drawing.Size(204, 24);
            this.labelDetDataCarreg.TabIndex = 8;
            this.labelDetDataCarreg.Text = "Data de Carregamento:";
            // 
            // labelDetDataAloj
            // 
            this.labelDetDataAloj.AutoSize = true;
            this.labelDetDataAloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDetDataAloj.Location = new System.Drawing.Point(63, 242);
            this.labelDetDataAloj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetDataAloj.Name = "labelDetDataAloj";
            this.labelDetDataAloj.Size = new System.Drawing.Size(179, 24);
            this.labelDetDataAloj.TabIndex = 7;
            this.labelDetDataAloj.Text = "Data de Alojamento:";
            // 
            // labelDetSituacao
            // 
            this.labelDetSituacao.AutoSize = true;
            this.labelDetSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDetSituacao.Location = new System.Drawing.Point(63, 208);
            this.labelDetSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetSituacao.Name = "labelDetSituacao";
            this.labelDetSituacao.Size = new System.Drawing.Size(87, 24);
            this.labelDetSituacao.TabIndex = 6;
            this.labelDetSituacao.Text = "Situação:";
            // 
            // labelDetPesoMedio
            // 
            this.labelDetPesoMedio.AutoSize = true;
            this.labelDetPesoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDetPesoMedio.Location = new System.Drawing.Point(63, 174);
            this.labelDetPesoMedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetPesoMedio.Name = "labelDetPesoMedio";
            this.labelDetPesoMedio.Size = new System.Drawing.Size(116, 24);
            this.labelDetPesoMedio.TabIndex = 5;
            this.labelDetPesoMedio.Text = "Peso Médio:";
            // 
            // labelDetPesoTotal
            // 
            this.labelDetPesoTotal.AutoSize = true;
            this.labelDetPesoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDetPesoTotal.Location = new System.Drawing.Point(63, 139);
            this.labelDetPesoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetPesoTotal.Name = "labelDetPesoTotal";
            this.labelDetPesoTotal.Size = new System.Drawing.Size(104, 24);
            this.labelDetPesoTotal.TabIndex = 4;
            this.labelDetPesoTotal.Text = "Peso Total:";
            // 
            // labelDetQuant
            // 
            this.labelDetQuant.AutoSize = true;
            this.labelDetQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDetQuant.Location = new System.Drawing.Point(63, 105);
            this.labelDetQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetQuant.Name = "labelDetQuant";
            this.labelDetQuant.Size = new System.Drawing.Size(113, 24);
            this.labelDetQuant.TabIndex = 3;
            this.labelDetQuant.Text = "Quantidade:";
            // 
            // labelDetCod
            // 
            this.labelDetCod.AutoSize = true;
            this.labelDetCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDetCod.Location = new System.Drawing.Point(415, 42);
            this.labelDetCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetCod.Name = "labelDetCod";
            this.labelDetCod.Size = new System.Drawing.Size(76, 24);
            this.labelDetCod.TabIndex = 2;
            this.labelDetCod.Text = "Código:";
            // 
            // labelDashDetalhes
            // 
            this.labelDashDetalhes.AutoSize = true;
            this.labelDashDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashDetalhes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDashDetalhes.Location = new System.Drawing.Point(45, 31);
            this.labelDashDetalhes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDashDetalhes.Name = "labelDashDetalhes";
            this.labelDashDetalhes.Size = new System.Drawing.Size(123, 46);
            this.labelDashDetalhes.TabIndex = 1;
            this.labelDashDetalhes.Text = "Lotes";
            // 
            // panelAgenda
            // 
            this.panelAgenda.BackColor = System.Drawing.Color.LightGray;
            this.panelAgenda.Controls.Add(this.btnVerTodos);
            this.panelAgenda.Controls.Add(this.btnAtualizarAgenda);
            this.panelAgenda.Controls.Add(this.dataGridAgenda);
            this.panelAgenda.Controls.Add(this.labelDashHoje);
            this.panelAgenda.Location = new System.Drawing.Point(113, 80);
            this.panelAgenda.Margin = new System.Windows.Forms.Padding(4);
            this.panelAgenda.Name = "panelAgenda";
            this.panelAgenda.Size = new System.Drawing.Size(661, 389);
            this.panelAgenda.TabIndex = 0;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.Gray;
            this.btnVerTodos.FlatAppearance.BorderSize = 0;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.White;
            this.btnVerTodos.Location = new System.Drawing.Point(358, 43);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(113, 40);
            this.btnVerTodos.TabIndex = 3;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnAtualizarAgenda
            // 
            this.btnAtualizarAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAtualizarAgenda.FlatAppearance.BorderSize = 0;
            this.btnAtualizarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAtualizarAgenda.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarAgenda.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnAtualizarAgenda.IconColor = System.Drawing.Color.White;
            this.btnAtualizarAgenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtualizarAgenda.IconSize = 30;
            this.btnAtualizarAgenda.Location = new System.Drawing.Point(493, 43);
            this.btnAtualizarAgenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizarAgenda.Name = "btnAtualizarAgenda";
            this.btnAtualizarAgenda.Size = new System.Drawing.Size(121, 39);
            this.btnAtualizarAgenda.TabIndex = 2;
            this.btnAtualizarAgenda.Text = "Atualizar";
            this.btnAtualizarAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizarAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtualizarAgenda.UseVisualStyleBackColor = false;
            this.btnAtualizarAgenda.Click += new System.EventHandler(this.btnAtualizarAgenda_Click);
            // 
            // dataGridAgenda
            // 
            this.dataGridAgenda.AllowUserToAddRows = false;
            this.dataGridAgenda.AllowUserToDeleteRows = false;
            this.dataGridAgenda.AllowUserToResizeRows = false;
            this.dataGridAgenda.AutoGenerateColumns = false;
            this.dataGridAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.finalizadaDataGridViewCheckBoxColumn,
            this.codAtividadeDataGridViewTextBoxColumn,
            this.atividadeDataGridViewTextBoxColumn,
            this.dataAtividadeDataGridViewTextBoxColumn,
            this.codVacinacaoDataGridViewTextBoxColumn,
            this.codRacaoDataGridViewTextBoxColumn,
            this.codMortalidadeDataGridViewTextBoxColumn,
            this.codVisitaDataGridViewTextBoxColumn,
            this.codLoteDataGridViewTextBoxColumn});
            this.dataGridAgenda.DataSource = this.agendaBindingSource;
            this.dataGridAgenda.Location = new System.Drawing.Point(55, 103);
            this.dataGridAgenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridAgenda.Name = "dataGridAgenda";
            this.dataGridAgenda.RowHeadersVisible = false;
            this.dataGridAgenda.RowHeadersWidth = 51;
            this.dataGridAgenda.RowTemplate.Height = 24;
            this.dataGridAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAgenda.Size = new System.Drawing.Size(557, 255);
            this.dataGridAgenda.TabIndex = 1;
            this.dataGridAgenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAgenda_CellDoubleClick);
            this.dataGridAgenda.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridAgenda_DataBindingComplete);
            // 
            // finalizadaDataGridViewCheckBoxColumn
            // 
            this.finalizadaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.finalizadaDataGridViewCheckBoxColumn.DataPropertyName = "Finalizada";
            this.finalizadaDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.finalizadaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.finalizadaDataGridViewCheckBoxColumn.Name = "finalizadaDataGridViewCheckBoxColumn";
            this.finalizadaDataGridViewCheckBoxColumn.Width = 60;
            // 
            // codAtividadeDataGridViewTextBoxColumn
            // 
            this.codAtividadeDataGridViewTextBoxColumn.DataPropertyName = "CodAtividade";
            this.codAtividadeDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.codAtividadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codAtividadeDataGridViewTextBoxColumn.Name = "codAtividadeDataGridViewTextBoxColumn";
            this.codAtividadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codAtividadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // atividadeDataGridViewTextBoxColumn
            // 
            this.atividadeDataGridViewTextBoxColumn.DataPropertyName = "Atividade";
            this.atividadeDataGridViewTextBoxColumn.HeaderText = "Atividade";
            this.atividadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.atividadeDataGridViewTextBoxColumn.Name = "atividadeDataGridViewTextBoxColumn";
            this.atividadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAtividadeDataGridViewTextBoxColumn
            // 
            this.dataAtividadeDataGridViewTextBoxColumn.DataPropertyName = "DataAtividade";
            this.dataAtividadeDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataAtividadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataAtividadeDataGridViewTextBoxColumn.Name = "dataAtividadeDataGridViewTextBoxColumn";
            this.dataAtividadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codVacinacaoDataGridViewTextBoxColumn
            // 
            this.codVacinacaoDataGridViewTextBoxColumn.DataPropertyName = "CodVacinacao";
            this.codVacinacaoDataGridViewTextBoxColumn.HeaderText = "CodVacinacao";
            this.codVacinacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codVacinacaoDataGridViewTextBoxColumn.Name = "codVacinacaoDataGridViewTextBoxColumn";
            this.codVacinacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codRacaoDataGridViewTextBoxColumn
            // 
            this.codRacaoDataGridViewTextBoxColumn.DataPropertyName = "CodRacao";
            this.codRacaoDataGridViewTextBoxColumn.HeaderText = "CodRacao";
            this.codRacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codRacaoDataGridViewTextBoxColumn.Name = "codRacaoDataGridViewTextBoxColumn";
            this.codRacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codMortalidadeDataGridViewTextBoxColumn
            // 
            this.codMortalidadeDataGridViewTextBoxColumn.DataPropertyName = "CodMortalidade";
            this.codMortalidadeDataGridViewTextBoxColumn.HeaderText = "CodMortalidade";
            this.codMortalidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codMortalidadeDataGridViewTextBoxColumn.Name = "codMortalidadeDataGridViewTextBoxColumn";
            this.codMortalidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // codVisitaDataGridViewTextBoxColumn
            // 
            this.codVisitaDataGridViewTextBoxColumn.DataPropertyName = "CodVisita";
            this.codVisitaDataGridViewTextBoxColumn.HeaderText = "CodVisita";
            this.codVisitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codVisitaDataGridViewTextBoxColumn.Name = "codVisitaDataGridViewTextBoxColumn";
            this.codVisitaDataGridViewTextBoxColumn.Visible = false;
            // 
            // codLoteDataGridViewTextBoxColumn
            // 
            this.codLoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codLoteDataGridViewTextBoxColumn.DataPropertyName = "CodLote";
            this.codLoteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.codLoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codLoteDataGridViewTextBoxColumn.Name = "codLoteDataGridViewTextBoxColumn";
            this.codLoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codLoteDataGridViewTextBoxColumn.Width = 80;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.fazendaSuinosDataSet;
            // 
            // fazendaSuinosDataSet
            // 
            this.fazendaSuinosDataSet.DataSetName = "fazendaSuinosDataSet";
            this.fazendaSuinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelDashHoje
            // 
            this.labelDashHoje.AutoSize = true;
            this.labelDashHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashHoje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDashHoje.Location = new System.Drawing.Point(47, 31);
            this.labelDashHoje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDashHoje.Name = "labelDashHoje";
            this.labelDashHoje.Size = new System.Drawing.Size(163, 46);
            this.labelDashHoje.TabIndex = 0;
            this.labelDashHoje.Text = "Agenda";
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStripAgenda
            // 
            this.contextMenuStripAgenda.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAgenda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocultarToolStripMenuItem});
            this.contextMenuStripAgenda.Name = "contextMenuStripAgenda";
            this.contextMenuStripAgenda.Size = new System.Drawing.Size(127, 28);
            // 
            // ocultarToolStripMenuItem
            // 
            this.ocultarToolStripMenuItem.Name = "ocultarToolStripMenuItem";
            this.ocultarToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.ocultarToolStripMenuItem.Text = "Ocultar";
            this.ocultarToolStripMenuItem.Click += new System.EventHandler(this.ocultarToolStripMenuItem_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1765, 992);
            this.Controls.Add(this.panelDashboard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelDashboard.ResumeLayout(false);
            this.panelConsRação.ResumeLayout(false);
            this.panelConsRação.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).EndInit();
            this.panelAcoesCorretivas.ResumeLayout(false);
            this.panelAcoesCorretivas.PerformLayout();
            this.panelDetalhesLote.ResumeLayout(false);
            this.panelDetalhesLote.PerformLayout();
            this.panelAgenda.ResumeLayout(false);
            this.panelAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaSuinosDataSet)).EndInit();
            this.contextMenuStripAgenda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Panel panelAgenda;
        private System.Windows.Forms.Panel panelAcoesCorretivas;
        private System.Windows.Forms.Panel panelDetalhesLote;
        private System.Windows.Forms.Label labelDashHoje;
        private System.Windows.Forms.Label labelDashAcoes;
        private System.Windows.Forms.Label labelDashDetalhes;
        private System.Windows.Forms.Label labelDetPesoTotal;
        private System.Windows.Forms.Label labelDetQuant;
        private System.Windows.Forms.Label labelDetCod;
        private System.Windows.Forms.Label labelDetCodGerente;
        private System.Windows.Forms.Label labelDetDataCarreg;
        private System.Windows.Forms.Label labelDetDataAloj;
        private System.Windows.Forms.Label labelDetSituacao;
        private System.Windows.Forms.Label labelDetPesoMedio;
        private System.Windows.Forms.TextBox campoDetCodGerente;
        private System.Windows.Forms.TextBox campoDetDataCarreg;
        private System.Windows.Forms.TextBox campoDetDataAloj;
        private System.Windows.Forms.TextBox campoDetSituacao;
        private System.Windows.Forms.TextBox campoDetPesoMedio;
        private System.Windows.Forms.TextBox campoDetPesoTotal;
        private System.Windows.Forms.TextBox campoDetQuant;
        private System.Windows.Forms.ComboBox comboCodLote_Det;
        private fazendaSuinosDataSet fazendaSuinosDataSet;
        public System.Windows.Forms.DataGridView dataGridAgenda;
        private FontAwesome.Sharp.IconButton btnAtualizarAgenda;
        private System.Windows.Forms.ComboBox comboCodProp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campoQuant;
        private System.Windows.Forms.TextBox campoLotesAbertos;
        private System.Windows.Forms.TextBox campoLotes;
        private System.Windows.Forms.TextBox campoPocilgas;
        private System.Windows.Forms.TextBox campoNomeProd;
        private System.Windows.Forms.TextBox campoNomeProp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelConsRação;
        private System.Windows.Forms.ComboBox comboLoteCons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConsumo;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private fazendaSuinosDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalizadaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVacinacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMortalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVisitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAgenda;
        private System.Windows.Forms.ToolStripMenuItem ocultarToolStripMenuItem;
    }
}