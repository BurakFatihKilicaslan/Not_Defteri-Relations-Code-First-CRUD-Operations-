namespace NotDefteri.Forms
{
    partial class Login
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
            lnkKaydol = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGiris = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            SuspendLayout();
            // 
            // lnkKaydol
            // 
            lnkKaydol.AutoSize = true;
            lnkKaydol.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnkKaydol.Location = new Point(246, 195);
            lnkKaydol.Name = "lnkKaydol";
            lnkKaydol.Size = new Size(65, 23);
            lnkKaydol.TabIndex = 24;
            lnkKaydol.TabStop = true;
            lnkKaydol.Text = "Kaydol";
            lnkKaydol.LinkClicked += lnkKaydol_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 27;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 47);
            label2.Name = "label2";
            label2.Size = new Size(129, 23);
            label2.TabIndex = 26;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 25;
            label1.Text = "Hoş Geldiniz";
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(17, 139);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(294, 41);
            btnGiris.TabIndex = 23;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(152, 95);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(159, 27);
            txtSifre.TabIndex = 22;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(152, 47);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(159, 27);
            txtKullaniciAdi.TabIndex = 21;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 235);
            Controls.Add(lnkKaydol);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkKaydol;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGiris;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
    }
}