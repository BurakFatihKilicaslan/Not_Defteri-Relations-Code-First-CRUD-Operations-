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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        UserRepository userRepository;
        private void AdminScreen_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void btnAktifPasif_Click(object sender, EventArgs e)
        {
            if (lstKullaniciBilgileri.SelectedItems.Count > 0)
            {
                User user = (User)lstKullaniciBilgileri.FocusedItem.Tag;
                if (user.isActive)
                {
                    user.isActive = false;
                }
                else
                {
                    user.isActive=true;
                }

                bool IsUpdated = userRepository.Update(user);
                if (IsUpdated)
                {
                    MessageBox.Show("Kullanıcı Güncellendi.");
                    FillListView();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Güncellenirken Beklenmeyen Bir Hata Oluştu.");
                }
            }
        }

        private void FillListView()
        {
            userRepository = new UserRepository();
            lstKullaniciBilgileri.Items.Clear();
            List<User> users = userRepository.GetAll();
            foreach (User user in users)
            {
                ListViewItem lvi = new();
                lvi.Text = user.FirstName;
                lvi.SubItems.Add(user.LastName);
                lvi.SubItems.Add(user.UserName);
                lvi.SubItems.Add(user.isActive ? "Aktif" : "Pasif");
                lvi.Tag = user;  //Obje tuttugu icin userID yerine user atadık Tag'e..
                lstKullaniciBilgileri.Items.Add(lvi);
            }
        }
    }
}
