namespace NotDefteri.Forms
{
    partial class SignIn
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
            label5 = new Label();
            txtSifreTekrar = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnKaydol = new Button();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 35;
            label5.Text = "Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifreTekrar.Location = new Point(153, 197);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(159, 27);
            txtSifreTekrar.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 151);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 34;
            label1.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 33;
            label4.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(153, 151);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(159, 27);
            txtSifre.TabIndex = 28;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(153, 103);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(159, 27);
            txtKullaniciAdi.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 32;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 31;
            label2.Text = "Ad:";
            // 
            // btnKaydol
            // 
            btnKaydol.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydol.Location = new Point(12, 240);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(300, 42);
            btnKaydol.TabIndex = 30;
            btnKaydol.Text = "Kayıt Ol";
            btnKaydol.UseVisualStyleBackColor = true;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(153, 57);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(159, 27);
            txtSoyad.TabIndex = 26;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(153, 9);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(159, 27);
            txtAd.TabIndex = 25;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 294);
            Controls.Add(label5);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnKaydol);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "SignIn";
            Text = "SignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtSifreTekrar;
        private Label label1;
        private Label label4;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private Label label2;
        private Button btnKaydol;
        private TextBox txtSoyad;
        private TextBox txtAd;
    }
}