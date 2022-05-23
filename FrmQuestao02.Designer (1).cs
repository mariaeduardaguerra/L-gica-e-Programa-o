namespace App2C131MariaEduardaGuerra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestao02));
            this.pnlSucos = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSabor = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSucos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSucos
            // 
            this.pnlSucos.BackColor = System.Drawing.Color.Teal;
            this.pnlSucos.Controls.Add(this.txtIngredientes);
            this.pnlSucos.Controls.Add(this.txtMarca);
            this.pnlSucos.Controls.Add(this.txtSabor);
            this.pnlSucos.Controls.Add(this.txtNome);
            this.pnlSucos.Controls.Add(this.lblIngredientes);
            this.pnlSucos.Controls.Add(this.lblSabor);
            this.pnlSucos.Controls.Add(this.lblMarca);
            this.pnlSucos.Controls.Add(this.lblNome);
            this.pnlSucos.Location = new System.Drawing.Point(43, 56);
            this.pnlSucos.Name = "pnlSucos";
            this.pnlSucos.Size = new System.Drawing.Size(521, 279);
            this.pnlSucos.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(248, 356);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 26);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(65, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarca.Location = new System.Drawing.Point(283, 43);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(61, 20);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSabor.Location = new System.Drawing.Point(65, 144);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(59, 20);
            this.lblSabor.TabIndex = 2;
            this.lblSabor.Text = "Sabor";
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIngredientes.Location = new System.Drawing.Point(283, 144);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(114, 20);
            this.lblIngredientes.TabIndex = 3;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Teal;
            this.txtNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNome.Location = new System.Drawing.Point(69, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtSabor
            // 
            this.txtSabor.BackColor = System.Drawing.Color.Teal;
            this.txtSabor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSabor.Location = new System.Drawing.Point(69, 204);
            this.txtSabor.Name = "txtSabor";
            this.txtSabor.Size = new System.Drawing.Size(168, 20);
            this.txtSabor.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Teal;
            this.txtMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMarca.Location = new System.Drawing.Point(287, 86);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(168, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.BackColor = System.Drawing.Color.Teal;
            this.txtIngredientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIngredientes.Location = new System.Drawing.Point(287, 204);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(168, 20);
            this.txtIngredientes.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(243, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "APP Prova";
            // 
            // FrmQuestao02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(6)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(613, 406);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pnlSucos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuestao02";
            this.Text = "Questão 02 - Design";
            this.pnlSucos.ResumeLayout(false);
            this.pnlSucos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSucos;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtSabor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTitulo;
    }
}

