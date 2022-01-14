using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1.Forms
{
    public partial class ChangeArtist : Form
    {
        private Artist Artist;

        public ChangeArtist()
        {
            InitializeComponent();
        }
        public ChangeArtist(Artist artist) : this()
        {
            this.Artist = artist;
        }

        private void ChangeArtist_Load(object sender, EventArgs e)
        {
            tbNewInfo.Text = Artist.artName;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    if (tbNewInfo.Text != "")
                    {
                        var artistName = db.Artist.FirstOrDefault(a=>a.artName == Artist.artName);
                        artistName.artName = tbNewInfo.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Информация обновилась");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ничего не случилось. Пустота не может заменить то, что уже существует.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
