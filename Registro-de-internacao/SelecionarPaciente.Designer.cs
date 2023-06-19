namespace Registro_de_internacao
{
    partial class SelecionarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarPaciente));
            this.txtcodPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtNomeAutor = new System.Windows.Forms.Label();
            this.dadosGrid4 = new System.Windows.Forms.DataGridView();
            this.colCodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodPaciente
            // 
            this.txtcodPaciente.Location = new System.Drawing.Point(101, 14);
            this.txtcodPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodPaciente.Name = "txtcodPaciente";
            this.txtcodPaciente.Size = new System.Drawing.Size(63, 22);
            this.txtcodPaciente.TabIndex = 48;
            this.txtcodPaciente.TextChanged += new System.EventHandler(this.txtcodPaciente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Código";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(101, 42);
            this.txtNomePaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(255, 22);
            this.txtNomePaciente.TabIndex = 46;
            this.txtNomePaciente.TextChanged += new System.EventHandler(this.txtNomePaciente_TextChanged);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.AutoSize = true;
            this.txtNomeAutor.Location = new System.Drawing.Point(17, 46);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(44, 16);
            this.txtNomeAutor.TabIndex = 45;
            this.txtNomeAutor.Text = "Nome";
            // 
            // dadosGrid4
            // 
            this.dadosGrid4.AllowUserToAddRows = false;
            this.dadosGrid4.AllowUserToDeleteRows = false;
            this.dadosGrid4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid4.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoPaciente,
            this.colNomePaciente,
            this.colMaePaciente,
            this.colDataNasc});
            this.dadosGrid4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid4.Location = new System.Drawing.Point(20, 68);
            this.dadosGrid4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dadosGrid4.Name = "dadosGrid4";
            this.dadosGrid4.ReadOnly = true;
            this.dadosGrid4.RowHeadersWidth = 51;
            this.dadosGrid4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid4.Size = new System.Drawing.Size(381, 177);
            this.dadosGrid4.TabIndex = 44;
            this.dadosGrid4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid4_CellDoubleClick);
            // 
            // colCodigoPaciente
            // 
            this.colCodigoPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colCodigoPaciente.FillWeight = 152.2843F;
            this.colCodigoPaciente.HeaderText = "Código";
            this.colCodigoPaciente.MinimumWidth = 6;
            this.colCodigoPaciente.Name = "colCodigoPaciente";
            this.colCodigoPaciente.ReadOnly = true;
            this.colCodigoPaciente.Width = 80;
            // 
            // colNomePaciente
            // 
            this.colNomePaciente.FillWeight = 73.85786F;
            this.colNomePaciente.HeaderText = "Nome";
            this.colNomePaciente.MinimumWidth = 6;
            this.colNomePaciente.Name = "colNomePaciente";
            this.colNomePaciente.ReadOnly = true;
            // 
            // colMaePaciente
            // 
            this.colMaePaciente.HeaderText = "Mãe";
            this.colMaePaciente.MinimumWidth = 6;
            this.colMaePaciente.Name = "colMaePaciente";
            this.colMaePaciente.ReadOnly = true;
            // 
            // colDataNasc
            // 
            this.colDataNasc.HeaderText = "DataNascimento";
            this.colDataNasc.MinimumWidth = 6;
            this.colDataNasc.Name = "colDataNasc";
            this.colDataNasc.ReadOnly = true;
            this.colDataNasc.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mãe";
            this.label2.Visible = false;
            // 
            // txtMae
            // 
            this.txtMae.Enabled = false;
            this.txtMae.Location = new System.Drawing.Point(101, 71);
            this.txtMae.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(255, 22);
            this.txtMae.TabIndex = 50;
            this.txtMae.Visible = false;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Enabled = false;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(160, 102);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(139, 22);
            this.dtpDataNascimento.TabIndex = 51;
            this.dtpDataNascimento.Visible = false;
            this.dtpDataNascimento.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Data de nascimento";
            this.label3.Visible = false;
            // 
            // SelecionarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.dadosGrid4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelecionarPaciente";
            this.Text = "Selecionar Paciente";
            this.Load += new System.EventHandler(this.SelecionarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Label txtNomeAutor;
        private System.Windows.Forms.DataGridView dadosGrid4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNasc;
    }
}