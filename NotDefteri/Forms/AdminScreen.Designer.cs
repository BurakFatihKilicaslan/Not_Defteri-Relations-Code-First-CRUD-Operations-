namespace NotDefteri.Forms
{
    partial class AdminScreen
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
            btnAktifPasif = new Button();
            lstKullaniciBilgileri = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnAktifPasif
            // 
            btnAktifPasif.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAktifPasif.Location = new Point(382, 12);
            btnAktifPasif.Name = "btnAktifPasif";
            btnAktifPasif.Size = new Size(140, 33);
            btnAktifPasif.TabIndex = 17;
            btnAktifPasif.Text = "Aktif / Pasif";
            btnAktifPasif.UseVisualStyleBackColor = true;
            btnAktifPasif.Click += btnAktifPasif_Click;
            // 
            // lstKullaniciBilgileri
            // 
            lstKullaniciBilgileri.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstKullaniciBilgileri.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstKullaniciBilgileri.FullRowSelect = true;
            lstKullaniciBilgileri.GridLines = true;
            lstKullaniciBilgileri.Location = new Point(-2, 51);
            lstKullaniciBilgileri.Name = "lstKullaniciBilgileri";
            lstKullaniciBilgileri.Size = new Size(536, 349);
            lstKullaniciBilgileri.TabIndex = 16;
            lstKullaniciBilgileri.UseCompatibleStateImageBehavior = false;
            lstKullaniciBilgileri.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Soyad";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kullanıcı Adı";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Durum";
            columnHeader4.Width = 100;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 397);
            Controls.Add(btnAktifPasif);
            Controls.Add(lstKullaniciBilgileri);
            Name = "AdminScreen";
            Text = "AdminScreen";
            Load += AdminScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAktifPasif;
        public ListView lstKullaniciBilgileri;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}