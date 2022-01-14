using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{

    public partial class ChangeAlbum : Form
    {
        private Album Album;
        public ChangeAlbum()
        {
            InitializeComponent();
        }
        public ChangeAlbum(Album album) :this()
        {
            this.Album = album;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(var db = new MusicMixModelDataContext())
                {
                    if (tbChangeName.Text !="")
                    {
                        var album = db.Album.FirstOrDefault(a=>a.albName == Album.albName);
                        album.albName = tbChangeName.Text;
                    }
                    if (tbChangeDate.Text != "")
                    {
                        Album album = db.Album.FirstOrDefault(d=>d.albReleaseDate == Album.albReleaseDate);
                        album.albReleaseDate = Convert.ToDateTime(tbChangeDate.Text);
                    }
                    MessageBox.Show("Информация обновлена");
                    db.SubmitChanges();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeAlbum_Load(object sender, EventArgs e)
        {
            tbChangeName.Text = Album.albName;
            tbChangeDate.Text = (Album.albReleaseDate).ToShortDateString();
        }
        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
