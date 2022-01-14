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
    public partial class ChangeSong : Form
    {
        private Song Song;
        public ChangeSong()
        {
            InitializeComponent();
        }
        public ChangeSong(Song song):this()
        {
            this.Song = song;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    if (tbNewInfo.Text != "")
                    {
                        var sName = db.Song.FirstOrDefault(s => s.songName == Song.songName);
                        sName.songName = tbNewInfo.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Информация обновлена");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пусто!Ничего не изменено.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void ChangeSong_Load(object sender, EventArgs e)
        {
            tbNewInfo.Text = Song.songName;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
