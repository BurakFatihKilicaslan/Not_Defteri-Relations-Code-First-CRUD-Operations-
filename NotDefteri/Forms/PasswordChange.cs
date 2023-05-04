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
    public partial class PasswordChange : Form
    {
        public PasswordChange(int userID)
        {
            InitializeComponent();
            this.userId = userID;
            userRepository = new UserRepository();
        }
        int userId;
        UserRepository userRepository;
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEskiSifre.Text) || string.IsNullOrWhiteSpace(txtYeniSifre.Text) || string.IsNullOrWhiteSpace(txtYeniSifreTekrar.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez");
            }
            else
            {
                if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
                {
                    MessageBox.Show("Şifreler Uyuşmuyor");
                }
                else
                {
                    User user = userRepository.GetById(userId);
                    if (user.Password == txtEskiSifre.Text)
                    {
                        user.Password = txtYeniSifre.Text;
                        bool isUpdated = userRepository.Update(user);
                        if (isUpdated)
                        {
                            MessageBox.Show("Güncellendi");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Güncellenemedi!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eski Şifreyi Yanlış Girdiniz");
                    }
                }
            }
        }
    }
}
