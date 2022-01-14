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
    public partial class ChangeGenre : Form
    {
        private Genre Genre;
        public ChangeGenre()
        {
            InitializeComponent();
        }
        public ChangeGenre(Genre genre):this()
        {
            this.Genre = genre;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    if (tbNewInfo.Text != "")
                    {
                        var genre = db.Genre.FirstOrDefault(g => g.genreName == Genre.genreName);
                        genre.genreName = tbNewInfo.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Информация обновлена");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пусто! Ничего не изменено");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void ChangeGenre_Load(object sender, EventArgs e)
        {
            tbNewInfo.Text = (Genre.genreName).ToString();
        }
    }
}
