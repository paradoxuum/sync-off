namespace SyncOff
{
    partial class SyncOff
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
            this.btnSync = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dvgFuncionarioMemoria = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNascismento = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.MaskedTextBox();
            this.cboDepartamentos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFuncionarioMemoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(12, 340);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(260, 23);
            this.btnSync.TabIndex = 6;
            this.btnSync.Text = "Sincronizar";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNome_KeyPress);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 139);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(94, 13);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Não sincronizados";
            // 
            // dvgFuncionarioMemoria
            // 
            this.dvgFuncionarioMemoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFuncionarioMemoria.Location = new System.Drawing.Point(12, 155);
            this.dvgFuncionarioMemoria.Name = "dvgFuncionarioMemoria";
            this.dvgFuncionarioMemoria.Size = new System.Drawing.Size(260, 150);
            this.dvgFuncionarioMemoria.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Salvar Offline";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(12, 55);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(55, 13);
            this.lblMatricula.TabIndex = 9;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // lblNascismento
            // 
            this.lblNascismento.AutoSize = true;
            this.lblNascismento.Location = new System.Drawing.Point(12, 81);
            this.lblNascismento.Name = "lblNascismento";
            this.lblNascismento.Size = new System.Drawing.Size(66, 13);
            this.lblNascismento.TabIndex = 10;
            this.lblNascismento.Text = "Nascimento:";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(84, 78);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(188, 20);
            this.txtNascimento.TabIndex = 3;
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(12, 107);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 11;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(73, 52);
            this.txtMatricula.Mask = "0000-0";
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(199, 20);
            this.txtMatricula.TabIndex = 2;
            // 
            // cboDepartamentos
            // 
            this.cboDepartamentos.FormattingEnabled = true;
            this.cboDepartamentos.Location = new System.Drawing.Point(95, 104);
            this.cboDepartamentos.Name = "cboDepartamentos";
            this.cboDepartamentos.Size = new System.Drawing.Size(177, 21);
            this.cboDepartamentos.TabIndex = 4;
            // 
            // SyncOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 375);
            this.Controls.Add(this.cboDepartamentos);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.lblNascismento);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dvgFuncionarioMemoria);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSync);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SyncOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyncOff";
            this.Load += new System.EventHandler(this.SyncOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFuncionarioMemoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dvgFuncionarioMemoria;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNascismento;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.MaskedTextBox txtMatricula;
        private System.Windows.Forms.ComboBox cboDepartamentos;
    }
}

