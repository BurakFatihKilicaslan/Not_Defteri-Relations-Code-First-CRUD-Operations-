using NotDefteri.Models;
using NotDefteri.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteri.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //userRepository = new UserRepository();
        }
        UserRepository userRepository;
        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez");
                return;
            }

            userRepository = new UserRepository();
            User user = userRepository.GetByUserName(txtKullaniciAdi.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı.\nKayıtlı Değilseniz Aşağıdaki Linke Tıklayınız");
            }
            else if (user.Password != txtSifre.Text)
            {
                MessageBox.Show("Şifre Yanlış");
            }
            else if (!user.isActive)
            {
                MessageBox.Show("Admin Kaydınızı Onaylamamıştır.Lütfen Admin İle İletişime Geçiniz");
            }
            else
            {
                switch (user.UserType)
                {
                    case Enums.UserType.Admin:
                        this.Hide();
                        AdminScreen adminScreen = new AdminScreen();
                        adminScreen.ShowDialog();
                        this.Show();
                        break;
                    case Enums.UserType.Standart:
                        this.Hide();
                        Main main = new Main(user.Id);
                        main.ShowDialog();
                        this.Show();
                        break;
                }
            }
        }

        private void lnkKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }
    }
}
