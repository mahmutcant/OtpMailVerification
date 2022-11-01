namespace OtpÖdev
{
    partial class Form1
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
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(103, 56);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(128, 20);
            this.txtEposta.TabIndex = 0;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(103, 102);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(128, 20);
            this.txtParola.TabIndex = 1;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // btnGir
            // 
            this.btnGir.Location = new System.Drawing.Point(103, 150);
            this.btnGir.Name = "btnGir";
            this.btnGir.Size = new System.Drawing.Size(128, 23);
            this.btnGir.TabIndex = 4;
            this.btnGir.Text = "Giriş";
            this.btnGir.UseVisualStyleBackColor = true;
            this.btnGir.Click += new System.EventHandler(this.btnGir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.btnGir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEposta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGir;
    }
}

