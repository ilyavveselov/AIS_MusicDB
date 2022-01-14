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
using WindowsFormsApp1.Forms;
using System.Data.Linq;

namespace WindowsFormsApp1.UserControls
{
    public partial class ucGenre : UserControl
    {
        private Genre Genre;
        public ucGenre()
        {
            InitializeComponent();
        }
        private void gUpdate()
        {
            using (var db = new MusicMixModelDataContext())
            {
                bsGenre_View.DataSource = db.Genre_View;
            }
        }
        private void gChange()
        {
            ChangeGenre changeGenre = new ChangeGenre(Genre);
            changeGenre.ShowDialog();
            gUpdate();
        }
        private void ucGenre_Load(object sender, EventArgs e)
        {
            try
            {
                using (MusicMixModelDataContext db = new MusicMixModelDataContext())
                {
                    bsGenre_View.DataSource = db.Genre_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void bsGenre_View_CurrentChanged(object sender, EventArgs e)
        {
            if (bsGenre_View.Count == 0) return;
            else
            {
                using (var db = new MusicMixModelDataContext())
                { 
                    var sv = bsGenre_View.Current as Genre_View;
                    Genre = db.Genre.FirstOrDefault(x => x.genreId == sv.gId);
                }
            }
        }

        private void tsChange_Click(object sender, EventArgs e)
        {
            gChange();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            AddGenre addGenre = new AddGenre();
            addGenre.ShowDialog();
            gUpdate();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
               "Удаление жанра приведет к удалению записей из других таблиц (Жанр -> Альбомы -> Песни), которые содержат данный тип. Может, вы хотите изменить название жанра?", "Сообщение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                gChange();
            }
            else if (dialogResult == DialogResult.No)
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var genreName = Genre.genreName;
                    var genre = db.Genre.FirstOrDefault(g => g.genreName == genreName);
                    Guid gId = genre.genreId;
                    db.Genre.DeleteOnSubmit(genre);
                    Table<Album> albums = db.GetTable<Album>();
                    List<Guid> aId = new List<Guid>();
                    foreach (var a in albums)
                    {
                        if (a.albGenreId == gId)
                        {
                            db.Album.DeleteOnSubmit(a);
                            aId.Add(a.albId);

                        }
                    }
                    Table<Song> songs = db.GetTable<Song>();
                    for (int i = 0; i < aId.Count; i++)
                    {
                        foreach (var s in songs)
                        {
                            if (s.songAlbumId == aId[i])
                            {
                                db.Song.DeleteOnSubmit(s);

                            }
                        }
                    }
                    DialogResult dialogForSure = MessageBox.Show("Вы уверены? Данная операция может стереть практически все записи.", "Сообщение", MessageBoxButtons.YesNo);
                    if (dialogForSure == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        gUpdate();
                    }
                    else if (dialogForSure == DialogResult.No)
                    {
                        MessageBox.Show("Удаление отменено");
                        gUpdate();
                    }
                }
            }
        }

        private void tsFilter_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    if (cbOrderBy.Text == "По возрастанию")
                    {
                        var sortedGenres = db.Genre_View.OrderBy(z => z.Название_жанра);
                        bsGenre_View.DataSource = sortedGenres;
                    }
                    else if (cbOrderBy.Text == "По убыванию")
                    {
                        var sortedGenres = db.Genre_View.OrderByDescending(z => z.Название_жанра);
                        bsGenre_View.DataSource = sortedGenres;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void tsReset_Click(object sender, EventArgs e)
        {
            gUpdate();
        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var query = db.Genre_View.Where(q => q.Название_жанра == tbSearch.Text);
                    if (query.Any())
                    {
                        bsGenre_View.DataSource = query;
                    }
                    else
                    {
                        MessageBox.Show("Ничего не найдено.");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
