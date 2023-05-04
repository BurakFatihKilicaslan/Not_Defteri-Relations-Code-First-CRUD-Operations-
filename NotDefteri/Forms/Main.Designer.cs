namespace NotDefteri.Forms
{
    partial class Main
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
            btnNotKaydet = new Button();
            btnNotSil = new Button();
            btnYeniNot = new Button();
            lnkSifreDegistir = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIcerik = new TextBox();
            txtBaslik = new TextBox();
            lboxNotlar = new ListBox();
            SuspendLayout();
            // 
            // btnNotKaydet
            // 
            btnNotKaydet.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotKaydet.Location = new Point(375, 344);
            btnNotKaydet.Name = "btnNotKaydet";
            btnNotKaydet.Size = new Size(105, 41);
            btnNotKaydet.TabIndex = 14;
            btnNotKaydet.Text = "Not Kaydet";
            btnNotKaydet.UseVisualStyleBackColor = true;
            btnNotKaydet.Click += btnNotKaydet_Click;
            // 
            // btnNotSil
            // 
            btnNotSil.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNotSil.Location = new Point(252, 344);
            btnNotSil.Name = "btnNotSil";
            btnNotSil.Size = new Size(105, 41);
            btnNotSil.TabIndex = 15;
            btnNotSil.Text = "Not Sil";
            btnNotSil.UseVisualStyleBackColor = true;
            btnNotSil.Click += btnNotSil_Click;
            // 
            // btnYeniNot
            // 
            btnYeniNot.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniNot.Location = new Point(130, 344);
            btnYeniNot.Name = "btnYeniNot";
            btnYeniNot.Size = new Size(105, 41);
            btnYeniNot.TabIndex = 16;
            btnYeniNot.Text = "Yeni Not";
            btnYeniNot.UseVisualStyleBackColor = true;
            btnYeniNot.Click += btnYeniNot_Click;
            // 
            // lnkSifreDegistir
            // 
            lnkSifreDegistir.AutoSize = true;
            lnkSifreDegistir.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lnkSifreDegistir.Location = new Point(12, 353);
            lnkSifreDegistir.Name = "lnkSifreDegistir";
            lnkSifreDegistir.Size = new Size(115, 23);
            lnkSifreDegistir.TabIndex = 18;
            lnkSifreDegistir.TabStop = true;
            lnkSifreDegistir.Text = "Şifre Değiştir";
            lnkSifreDegistir.LinkClicked += lnkSifreDegistir_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(193, 69);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 21;
            label3.Text = "İçerik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(193, 7);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 20;
            label2.Text = "Başlık";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 19;
            label1.Text = "Notlarım";
            // 
            // txtIcerik
            // 
            txtIcerik.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIcerik.Location = new Point(193, 95);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik";
            txtIcerik.Size = new Size(287, 220);
            txtIcerik.TabIndex = 13;
            // 
            // txtBaslik
            // 
            txtBaslik.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBaslik.Location = new Point(193, 33);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(287, 31);
            txtBaslik.TabIndex = 12;
            // 
            // lboxNotlar
            // 
            lboxNotlar.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lboxNotlar.FormattingEnabled = true;
            lboxNotlar.ItemHeight = 23;
            lboxNotlar.Location = new Point(12, 35);
            lboxNotlar.Name = "lboxNotlar";
            lboxNotlar.Size = new Size(164, 280);
            lboxNotlar.TabIndex = 17;
            lboxNotlar.SelectedIndexChanged += lboxNotlar_SelectedIndexChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 399);
            Controls.Add(btnNotKaydet);
            Controls.Add(btnNotSil);
            Controls.Add(btnYeniNot);
            Controls.Add(lnkSifreDegistir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIcerik);
            Controls.Add(txtBaslik);
            Controls.Add(lboxNotlar);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNotKaydet;
        private Button btnNotSil;
        private Button btnYeniNot;
        private LinkLabel lnkSifreDegistir;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIcerik;
        private TextBox txtBaslik;
        private ListBox lboxNotlar;
    }
}