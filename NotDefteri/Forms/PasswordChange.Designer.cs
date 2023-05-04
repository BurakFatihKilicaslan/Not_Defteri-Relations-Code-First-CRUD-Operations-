namespace NotDefteri.Forms
{
    partial class PasswordChange
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
            btnSifreDegistir = new Button();
            label4 = new Label();
            txtYeniSifreTekrar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtYeniSifre = new TextBox();
            txtEskiSifre = new TextBox();
            SuspendLayout();
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSifreDegistir.Location = new Point(12, 146);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(317, 42);
            btnSifreDegistir.TabIndex = 31;
            btnSifreDegistir.Text = "Şifre Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = true;
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(147, 23);
            label4.TabIndex = 34;
            label4.Text = "Yeni Şifre Tekrar:";
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(170, 103);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(159, 23);
            txtYeniSifreTekrar.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 33;
            label3.Text = "Yeni Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 32;
            label2.Text = "Eski Şifre:";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(170, 57);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(159, 23);
            txtYeniSifre.TabIndex = 29;
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(170, 9);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.Size = new Size(159, 23);
            txtEskiSifre.TabIndex = 28;
            // 
            // PasswordChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 205);
            Controls.Add(btnSifreDegistir);
            Controls.Add(label4);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtEskiSifre);
            Name = "PasswordChange";
            Text = "PasswordChange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSifreDegistir;
        private Label label4;
        private TextBox txtYeniSifreTekrar;
        private Label label3;
        private Label label2;
        private TextBox txtYeniSifre;
        private TextBox txtEskiSifre;
    }
}