namespace App2C131MariaEduardaGuerra
{
    partial class FrmQuestao04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestao04));
            this.lblQntMilho = new System.Windows.Forms.Label();
            this.lblQntSuco = new System.Windows.Forms.Label();
            this.txtQntMilho = new System.Windows.Forms.TextBox();
            this.txtQntSuco = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQntMilho
            // 
            this.lblQntMilho.AutoSize = true;
            this.lblQntMilho.Location = new System.Drawing.Point(74, 55);
            this.lblQntMilho.Name = "lblQntMilho";
            this.lblQntMilho.Size = new System.Drawing.Size(32, 13);
            this.lblQntMilho.TabIndex = 0;
            this.lblQntMilho.Text = "Milho";
            // 
            // lblQntSuco
            // 
            this.lblQntSuco.AutoSize = true;
            this.lblQntSuco.Location = new System.Drawing.Point(74, 149);
            this.lblQntSuco.Name = "lblQntSuco";
            this.lblQntSuco.Size = new System.Drawing.Size(32, 13);
            this.lblQntSuco.TabIndex = 1;
            this.lblQntSuco.Text = "Suco";
            // 
            // txtQntMilho
            // 
            this.txtQntMilho.Location = new System.Drawing.Point(77, 96);
            this.txtQntMilho.Name = "txtQntMilho";
            this.txtQntMilho.Size = new System.Drawing.Size(100, 20);
            this.txtQntMilho.TabIndex = 2;
            // 
            // txtQntSuco
            // 
            this.txtQntSuco.Location = new System.Drawing.Point(77, 197);
            this.txtQntSuco.Name = "txtQntSuco";
            this.txtQntSuco.Size = new System.Drawing.Size(100, 20);
            this.txtQntSuco.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(163, 262);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmQuestao04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtQntSuco);
            this.Controls.Add(this.txtQntMilho);
            this.Controls.Add(this.lblQntSuco);
            this.Controls.Add(this.lblQntMilho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuestao04";
            this.Text = "Questão 04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQntMilho;
        private System.Windows.Forms.Label lblQntSuco;
        private System.Windows.Forms.TextBox txtQntMilho;
        private System.Windows.Forms.TextBox txtQntSuco;
        private System.Windows.Forms.Button btnCalcular;
    }
}