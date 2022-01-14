using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Forms
{
    public partial class AddGenre : Form
    {
        public AddGenre()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addName = txtboxAdd.Text;
            bool isInDb = false;
            try
            {
                using (MusicMixModelDataContext db = new MusicMixModelDataContext())
                {
                    Table<Genre> genres = db.GetTable<Genre>();
                    foreach (var g in genres)
                    {
                        if (g.genreName == addName)
                        {
                            isInDb = true;
                            MessageBox.Show($"Жанр {addName} уже существует.");
                            break;
                        }
                    }
                    if (isInDb == false)
                    {
                        Genre genre = new Genre { genreId = Guid.NewGuid(), genreName = addName.ToString() };
                        db.Genre.InsertOnSubmit(genre);
                        db.SubmitChanges();
                        MessageBox.Show($"Жанр {addName} добавлен.");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
