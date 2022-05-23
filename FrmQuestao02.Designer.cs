namespace AppProva31MariaEduardaGuerra
{
    partial class FrmQuestao02
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDtNascimento = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtDtNascimento = new System.Windows.Forms.TextBox();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdade.Location = new System.Drawing.Point(51, 46);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(63, 16);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "IDADE";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSexo.Location = new System.Drawing.Point(51, 119);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 16);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "SEXO";
            // 
            // lblDtNascimento
            // 
            this.lblDtNascimento.AutoSize = true;
            this.lblDtNascimento.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNascimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtNascimento.Location = new System.Drawing.Point(287, 128);
            this.lblDtNascimento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDtNascimento.Name = "lblDtNascimento";
            this.lblDtNascimento.Size = new System.Drawing.Size(208, 16);
            this.lblDtNascimento.TabIndex = 4;
            this.lblDtNascimento.Text = "DATA DE NASCIMENTO";
            this.lblDtNascimento.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCelular.Location = new System.Drawing.Point(287, 46);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(83, 16);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Text = "CELULAR";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(54, 75);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(164, 25);
            this.txtIdade.TabIndex = 6;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(54, 152);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(164, 25);
            this.txtSexo.TabIndex = 7;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(290, 75);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(164, 25);
            this.txtCelular.TabIndex = 8;
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(290, 152);
            this.txtDtNascimento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(164, 25);
            this.txtDtNascimento.TabIndex = 9;
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCadastro.Controls.Add(this.txtDtNascimento);
            this.pnlCadastro.Controls.Add(this.lblDtNascimento);
            this.pnlCadastro.Controls.Add(this.txtCelular);
            this.pnlCadastro.Controls.Add(this.txtSexo);
            this.pnlCadastro.Controls.Add(this.txtIdade);
            this.pnlCadastro.Controls.Add(this.lblCelular);
            this.pnlCadastro.Controls.Add(this.lblSexo);
            this.pnlCadastro.Controls.Add(this.lblIdade);
            this.pnlCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCadastro.Location = new System.Drawing.Point(-8, 11);
            this.pnlCadastro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(888, 249);
            this.pnlCadastro.TabIndex = 10;
            this.pnlCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastro_Paint);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(198, 296);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 28);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // FrmQuestao02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(521, 371);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pnlCadastro);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmQuestao02";
            this.Text = "Form1";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDtNascimento;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDtNascimento;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

