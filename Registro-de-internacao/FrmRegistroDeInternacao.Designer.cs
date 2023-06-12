﻿namespace Registro_de_internacao
{
    partial class FrmRegistroDeInternacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCns = new System.Windows.Forms.TextBox();
            this.dtpHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClinicaMedica = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLeito = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCentroCusto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHipoteseDiagnostica = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCarregarLocal = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colCodPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProntuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodInterncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClinicaMedica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCentroDeCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHipoteseDiagnostica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Location = new System.Drawing.Point(93, 12);
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.ReadOnly = true;
            this.txtCodPaciente.Size = new System.Drawing.Size(50, 20);
            this.txtCodPaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prontuário";
            // 
            // txtProntuario
            // 
            this.txtProntuario.Location = new System.Drawing.Point(93, 38);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(50, 20);
            this.txtProntuario.TabIndex = 3;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(224, 38);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(97, 20);
            this.dtpDataEntrada.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora entrada";
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(401, 38);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(73, 20);
            this.dtpHoraEntrada.TabIndex = 7;
            this.dtpHoraEntrada.Value = new System.DateTime(2023, 6, 15, 0, 0, 0, 0);
            // 
            // dtpDataSaida
            // 
            this.dtpDataSaida.Enabled = false;
            this.dtpDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaida.Location = new System.Drawing.Point(229, 64);
            this.dtpDataSaida.Name = "dtpDataSaida";
            this.dtpDataSaida.Size = new System.Drawing.Size(101, 20);
            this.dtpDataSaida.TabIndex = 8;
            this.dtpDataSaida.Value = new System.DateTime(1753, 1, 1, 11, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data saida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CNS";
            // 
            // txtCns
            // 
            this.txtCns.Location = new System.Drawing.Point(47, 64);
            this.txtCns.Name = "txtCns";
            this.txtCns.Size = new System.Drawing.Size(88, 20);
            this.txtCns.TabIndex = 11;
            // 
            // dtpHoraSaida
            // 
            this.dtpHoraSaida.Enabled = false;
            this.dtpHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSaida.Location = new System.Drawing.Point(401, 64);
            this.dtpHoraSaida.Name = "dtpHoraSaida";
            this.dtpHoraSaida.ShowUpDown = true;
            this.dtpHoraSaida.Size = new System.Drawing.Size(73, 20);
            this.dtpHoraSaida.TabIndex = 13;
            this.dtpHoraSaida.Value = new System.DateTime(2023, 6, 15, 0, 0, 0, 0);
            //this.dtpHoraSaida.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hora saida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Clinica médica";
            // 
            // txtClinicaMedica
            // 
            this.txtClinicaMedica.Location = new System.Drawing.Point(93, 117);
            this.txtClinicaMedica.Name = "txtClinicaMedica";
            this.txtClinicaMedica.Size = new System.Drawing.Size(165, 20);
            this.txtClinicaMedica.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Localização";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(93, 143);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(165, 20);
            this.txtLocalizacao.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Leito";
            // 
            // txtLeito
            // 
            this.txtLeito.Location = new System.Drawing.Point(354, 142);
            this.txtLeito.Name = "txtLeito";
            this.txtLeito.Size = new System.Drawing.Size(120, 20);
            this.txtLeito.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Centro de custo";
            // 
            // txtCentroCusto
            // 
            this.txtCentroCusto.Location = new System.Drawing.Point(352, 116);
            this.txtCentroCusto.Name = "txtCentroCusto";
            this.txtCentroCusto.Size = new System.Drawing.Size(122, 20);
            this.txtCentroCusto.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Hipótese diagnóstica";
            // 
            // txtHipoteseDiagnostica
            // 
            this.txtHipoteseDiagnostica.Location = new System.Drawing.Point(124, 169);
            this.txtHipoteseDiagnostica.Name = "txtHipoteseDiagnostica";
            this.txtHipoteseDiagnostica.Size = new System.Drawing.Size(350, 20);
            this.txtHipoteseDiagnostica.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Médico";
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(93, 91);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(165, 20);
            this.txtMedico.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(264, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "CRM";
            // 
            // txtCrm
            // 
            this.txtCrm.Location = new System.Drawing.Point(352, 90);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(122, 20);
            this.txtCrm.TabIndex = 27;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(124, 195);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(350, 20);
            this.txtDiagnostico.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Diagnóstico";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Situação";
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Items.AddRange(new object[] {
            "Internado",
            "Óbito",
            "Alta"});
            this.cbxSituacao.Location = new System.Drawing.Point(124, 221);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(121, 21);
            this.cbxSituacao.TabIndex = 31;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(318, 221);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 21);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(399, 221);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 21);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCarregarLocal
            // 
            this.btnCarregarLocal.FlatAppearance.BorderSize = 0;
            this.btnCarregarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarLocal.Image = global::Registro_de_internacao.Properties.Resources.magnifying_glass_icon;
            this.btnCarregarLocal.Location = new System.Drawing.Point(148, 12);
            this.btnCarregarLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarregarLocal.Name = "btnCarregarLocal";
            this.btnCarregarLocal.Size = new System.Drawing.Size(17, 18);
            this.btnCarregarLocal.TabIndex = 32;
            this.btnCarregarLocal.UseVisualStyleBackColor = true;
            this.btnCarregarLocal.Click += new System.EventHandler(this.btnCarregarLocal_Click);
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(170, 15);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(35, 13);
            this.lblNomePaciente.TabIndex = 35;
            this.lblNomePaciente.Text = "Nome";
            this.lblNomePaciente.Visible = false;
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodPaciente,
            this.colProntuario,
            this.colDataEntrada,
            this.colHoraEntrada,
            this.colCodInterncao,
            this.colCns,
            this.colDataSaida,
            this.colHoraSaida,
            this.colMedico,
            this.colCRM,
            this.colClinicaMedica,
            this.colCentroDeCusto,
            this.colLocalizacao,
            this.colLeito,
            this.colHipoteseDiagnostica,
            this.colDiagnostico,
            this.colSituacao});
            this.dadosGrid.Location = new System.Drawing.Point(12, 248);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(587, 225);
            this.dadosGrid.TabIndex = 36;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // colCodPaciente
            // 
            this.colCodPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodPaciente.FillWeight = 152.2843F;
            this.colCodPaciente.HeaderText = "Código paciente";
            this.colCodPaciente.MinimumWidth = 6;
            this.colCodPaciente.Name = "colCodPaciente";
            this.colCodPaciente.ReadOnly = true;
            // 
            // colProntuario
            // 
            this.colProntuario.HeaderText = "Prontuário";
            this.colProntuario.MinimumWidth = 6;
            this.colProntuario.Name = "colProntuario";
            this.colProntuario.ReadOnly = true;
            // 
            // colDataEntrada
            // 
            this.colDataEntrada.HeaderText = "Data entrada";
            this.colDataEntrada.MinimumWidth = 6;
            this.colDataEntrada.Name = "colDataEntrada";
            this.colDataEntrada.ReadOnly = true;
            // 
            // colHoraEntrada
            // 
            this.colHoraEntrada.HeaderText = "Hora Entrada";
            this.colHoraEntrada.MinimumWidth = 6;
            this.colHoraEntrada.Name = "colHoraEntrada";
            this.colHoraEntrada.ReadOnly = true;
            this.colHoraEntrada.Visible = false;
            // 
            // colCodInterncao
            // 
            this.colCodInterncao.HeaderText = "Código internação";
            this.colCodInterncao.Name = "colCodInterncao";
            this.colCodInterncao.ReadOnly = true;
            // 
            // colCns
            // 
            this.colCns.HeaderText = "Cns";
            this.colCns.Name = "colCns";
            this.colCns.ReadOnly = true;
            this.colCns.Visible = false;
            // 
            // colDataSaida
            // 
            this.colDataSaida.HeaderText = "Data saida";
            this.colDataSaida.MinimumWidth = 6;
            this.colDataSaida.Name = "colDataSaida";
            this.colDataSaida.ReadOnly = true;
            // 
            // colHoraSaida
            // 
            this.colHoraSaida.HeaderText = "Hora saida";
            this.colHoraSaida.MinimumWidth = 6;
            this.colHoraSaida.Name = "colHoraSaida";
            this.colHoraSaida.ReadOnly = true;
            this.colHoraSaida.Visible = false;
            // 
            // colMedico
            // 
            this.colMedico.HeaderText = "Medico";
            this.colMedico.MinimumWidth = 6;
            this.colMedico.Name = "colMedico";
            this.colMedico.ReadOnly = true;
            this.colMedico.Visible = false;
            // 
            // colCRM
            // 
            this.colCRM.HeaderText = "CRM";
            this.colCRM.MinimumWidth = 6;
            this.colCRM.Name = "colCRM";
            this.colCRM.ReadOnly = true;
            this.colCRM.Visible = false;
            // 
            // colClinicaMedica
            // 
            this.colClinicaMedica.HeaderText = "Clinica médica";
            this.colClinicaMedica.MinimumWidth = 6;
            this.colClinicaMedica.Name = "colClinicaMedica";
            this.colClinicaMedica.ReadOnly = true;
            this.colClinicaMedica.Visible = false;
            // 
            // colCentroDeCusto
            // 
            this.colCentroDeCusto.HeaderText = "Centro de custo";
            this.colCentroDeCusto.MinimumWidth = 6;
            this.colCentroDeCusto.Name = "colCentroDeCusto";
            this.colCentroDeCusto.ReadOnly = true;
            this.colCentroDeCusto.Visible = false;
            // 
            // colLocalizacao
            // 
            this.colLocalizacao.HeaderText = "Localização";
            this.colLocalizacao.MinimumWidth = 6;
            this.colLocalizacao.Name = "colLocalizacao";
            this.colLocalizacao.ReadOnly = true;
            this.colLocalizacao.Visible = false;
            // 
            // colLeito
            // 
            this.colLeito.HeaderText = "Leito";
            this.colLeito.MinimumWidth = 6;
            this.colLeito.Name = "colLeito";
            this.colLeito.ReadOnly = true;
            this.colLeito.Visible = false;
            // 
            // colHipoteseDiagnostica
            // 
            this.colHipoteseDiagnostica.HeaderText = "Hipotese diagnóstica";
            this.colHipoteseDiagnostica.MinimumWidth = 6;
            this.colHipoteseDiagnostica.Name = "colHipoteseDiagnostica";
            this.colHipoteseDiagnostica.ReadOnly = true;
            this.colHipoteseDiagnostica.Visible = false;
            // 
            // colDiagnostico
            // 
            this.colDiagnostico.HeaderText = "Diagnostico";
            this.colDiagnostico.MinimumWidth = 6;
            this.colDiagnostico.Name = "colDiagnostico";
            this.colDiagnostico.ReadOnly = true;
            this.colDiagnostico.Visible = false;
            // 
            // colSituacao
            // 
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.MinimumWidth = 6;
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            this.colSituacao.Visible = false;
            // 
            // FrmRegistroDeInternacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 485);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCarregarLocal);
            this.Controls.Add(this.cbxSituacao);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtCrm);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtHipoteseDiagnostica);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCentroCusto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLeito);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClinicaMedica);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpHoraSaida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCns);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDataSaida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.txtProntuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodPaciente);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroDeInternacao";
            this.Text = "Registro de Internação";
            this.Load += new System.EventHandler(this.FrmRegistroDeInternacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpDataSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCns;
        private System.Windows.Forms.DateTimePicker dtpHoraSaida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClinicaMedica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLeito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCentroCusto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHipoteseDiagnostica;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCrm;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Button btnCarregarLocal;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProntuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodInterncao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClinicaMedica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCentroDeCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHipoteseDiagnostica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
    }
}

