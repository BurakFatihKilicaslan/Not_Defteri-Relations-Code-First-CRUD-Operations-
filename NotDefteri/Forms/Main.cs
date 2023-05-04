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
    public partial class Main : Form
    {
        public Main(int userID)
        {
            InitializeComponent();
            this.userId = userID;
        }
        int userId;
        NoteRepository notesRepository;
        private void Main_Load(object sender, EventArgs e)
        {
            notesRepository = new NoteRepository();
            List<Note> notes = notesRepository.GetNotesByUserId(userId);
            lboxNotlar.ValueMember = "Id";  //Arka planda idlerin notlarını tuttuk
            lboxNotlar.DisplayMember = "Title";
            lboxNotlar.DataSource = notes;
            ResetForm();
        }

        private void lboxNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxNotlar.SelectedIndex != -1)
            {
                int noteId = (int)lboxNotlar.SelectedValue;
                Note note = notesRepository.GetById(noteId);
                txtBaslik.Text = note.Title;
                txtIcerik.Text = note.Content;
                btnNotSil.Enabled = true;
            }
            else
            {
                ResetForm();
            }
        }

        private void ResetForm()
        {
            lboxNotlar.SelectedIndex = -1;
            txtBaslik.Clear();
            txtIcerik.Clear();
            btnNotSil.Enabled = false;
        }

        private void btnYeniNot_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            if (lboxNotlar.SelectedIndex != -1)
            {
                DialogResult dr = MessageBox.Show("Gerçekten Silmek İstiyor Musunuz", "Silme Onayı", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    int noteId = (int)lboxNotlar.SelectedValue;
                    bool isDeleted = notesRepository.Delete(noteId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Başarı İle Silindi");
                        ResetForm();
                        lboxNotlar.DataSource = notesRepository.GetById(userId); //Sildikten sonra lboxı güncellemiş oluyoruz. Silindikten sonraki veriler listelenmş oluyor..
                    }
                    else
                    {
                        MessageBox.Show("Silinemedi");
                    }
                }
            }
        }

        private void btnNotKaydet_Click(object sender, EventArgs e)
        {
            //Var Olan bir Notu günceller..
            if (lboxNotlar.SelectedIndex != -1)
            {
                int noteId = (int)lboxNotlar.SelectedValue;
                Note note = notesRepository.GetById(noteId);
                note.Title = txtBaslik.Text;
                note.Content = txtIcerik.Text;
                bool isUpdated = notesRepository.Update(note);
                if (isUpdated)
                {
                    MessageBox.Show("Başarıyla Güncellendi.");
                    lboxNotlar.DataSource = notesRepository.GetById(userId);//KAydettikten sonra lboxı güncellemiş oluyoruz. Kaydettikten sonraki veriler listelenmş oluyor..
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Güncellenemedi.");
                }
            }
            else
            {
                //Yeni Not Ekler..
                Note note = new Note();
                note.UserID = userId;
                note.Title = txtBaslik.Text;
                note.Content = txtIcerik.Text;
                bool isAdded = notesRepository.Add(note);
                if (isAdded)
                {
                    MessageBox.Show("Başarıyla Eklendi.");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Eklenemedi.");
                }
            }
        }

        private void lnkSifreDegistir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChange passwordChange = new(userId);
            passwordChange.ShowDialog();
        }
    }
}
