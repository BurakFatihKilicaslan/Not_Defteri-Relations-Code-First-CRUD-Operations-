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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        UserRepository userRepository;
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) ||string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtSifreTekrar.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez");
                return;     //Sadece if yazdığımız icin aşağıya doğru kod akmasın diye return yazdık..
            }
            if (txtSifreTekrar.Text != txtSifre.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
            else
            {   
                userRepository = new UserRepository();
                User user = userRepository.GetByUserName(txtKullaniciAdi.Text);
                if (user != null)
                {
                    MessageBox.Show("Bu İsimde Kullanıcı Mevcuttur.");
                }
                else
                {   //New()lemez isek stackte newUser adlı degisken heapte referans gostermez..
                    User newUser = new User();
                    newUser.FirstName = txtAd.Text;
                    newUser.LastName = txtSoyad.Text;
                    newUser.UserName = txtKullaniciAdi.Text;
                    newUser.Password = txtSifre.Text;
                    newUser.UserType = Enums.UserType.Standart;

                    bool isAdded = userRepository.Add(newUser);
                    if (isAdded)
                    {
                        MessageBox.Show("Kaydınız Başarıyla Gerçekleştirildi");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kaydolurken Beklenmeyen Bir Hata Oluştu");
                    }
                }
            }
        }
    }
}
