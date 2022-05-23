namespace App2C131MariaEduardaGuerra
{
    partial class FrmQuestao03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestao03));
            this.lblTotalFuncionarios = new System.Windows.Forms.Label();
            this.lblQntSolteiros = new System.Windows.Forms.Label();
            this.txtTotalFuncionarios = new System.Windows.Forms.TextBox();
            this.txtQntSolteiros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalFuncionarios
            // 
            this.lblTotalFuncionarios.AutoSize = true;
            this.lblTotalFuncionarios.Location = new System.Drawing.Point(66, 34);
            this.lblTotalFuncionarios.Name = "lblTotalFuncionarios";
            this.lblTotalFuncionarios.Size = new System.Drawing.Size(109, 13);
            this.lblTotalFuncionarios.TabIndex = 0;
            this.lblTotalFuncionarios.Text = "Total de Funcionários";
            // 
            // lblQntSolteiros
            // 
            this.lblQntSolteiros.AutoSize = true;
            this.lblQntSolteiros.Location = new System.Drawing.Point(66, 134);
            this.lblQntSolteiros.Name = "lblQntSolteiros";
            this.lblQntSolteiros.Size = new System.Drawing.Size(120, 13);
            this.lblQntSolteiros.TabIndex = 1;
            this.lblQntSolteiros.Text = "Quantidade de Solteiros";
            // 
            // txtTotalFuncionarios
            // 
            this.txtTotalFuncionarios.Location = new System.Drawing.Point(69, 77);
            this.txtTotalFuncionarios.Name = "txtTotalFuncionarios";
            this.txtTotalFuncionarios.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFuncionarios.TabIndex = 2;
            // 
            // txtQntSolteiros
            // 
            this.txtQntSolteiros.Location = new System.Drawing.Point(69, 176);
            this.txtQntSolteiros.Name = "txtQntSolteiros";
            this.txtQntSolteiros.Size = new System.Drawing.Size(100, 20);
            this.txtQntSolteiros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(149, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(266, 134);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // FrmQuestao03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 304);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtQntSolteiros);
            this.Controls.Add(this.txtTotalFuncionarios);
            this.Controls.Add(this.lblQntSolteiros);
            this.Controls.Add(this.lblTotalFuncionarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuestao03";
            this.Text = "Questão 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalFuncionarios;
        private System.Windows.Forms.Label lblQntSolteiros;
        private System.Windows.Forms.TextBox txtTotalFuncionarios;
        private System.Windows.Forms.TextBox txtQntSolteiros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}