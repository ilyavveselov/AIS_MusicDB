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
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1.UserControls
{
    public partial class ucSong : UserControl
    {
        private Song Song;
        public ucSong()
        {
            InitializeComponent();
        }
        private void sChange()
        {
            ChangeSong changeSong = new ChangeSong(Song);
            changeSong.ShowDialog();
            sUpdate();
        }
        private void sUpdate()
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    bsSong_View.DataSource = db.Song_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucSong_Load(object sender, EventArgs e)
        {
            try
            {
                using (MusicMixModelDataContext db = new MusicMixModelDataContext())
                {
                    bsSong_View.DataSource = db.Song_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void bsSong_View_CurrentChanged(object sender, EventArgs e)
        {
            if (bsSong_View.Count == 0) return;
            else
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var sv = bsSong_View.Current as Song_View;
                    Song = db.Song.FirstOrDefault(x => x.songId == sv.sngId);
                }
            }
        }

        private void tsChange_Click(object sender, EventArgs e)
        {
            sChange();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            AddSong addSong = new AddSong();
            addSong.ShowDialog();
            sUpdate();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultFirst = MessageBox.Show($"Вы точно хотите удалить {Song.songName}?", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResultFirst == DialogResult.Yes)
            {
                try
                {
                    using (var db = new MusicMixModelDataContext())
                    {
                        Table<Song> songs = db.GetTable<Song>();
                        int counter = 0;
                        var album = db.Album.FirstOrDefault(a => a.albId == Song.songAlbumId);
                        foreach (var s in songs)
                        {
                            if (s.songAlbumId == album.albId)
                            {
                                counter += 1;
                            }
                        }
                        MessageBox.Show(counter.ToString());
                        if (counter > 1)
                        {
                            var songName = Song.songName;
                            var song = db.Song.FirstOrDefault(s => s.songName == songName);
                            db.Song.DeleteOnSubmit(song);
                            db.SubmitChanges();
                            MessageBox.Show("Удалилось");
                            sUpdate();
                        }
                        else if (counter == 1)
                        {
                            DialogResult dialogResultSecond = MessageBox.Show("Осталась всего одна песня в этом альбоме. " +
                                "Если вы ее решите удалить, то тогда удалятся все данные, причастные к этой песне " +
                                "(Песня->Альбом->Артист. Может, вы хотите изменить название песни?", "Предупреждение", MessageBoxButtons.YesNo);
                            if (dialogResultSecond == DialogResult.Yes)
                            {
                                sChange();
                            }
                            else if (dialogResultSecond == DialogResult.No)
                            {
                                var songName = Song.songName;
                                var song = db.Song.FirstOrDefault(s => s.songName == songName);
                                db.Song.DeleteOnSubmit(song);
                                album = db.Album.FirstOrDefault(a => a.albId == Song.songAlbumId);
                                db.Album.DeleteOnSubmit(album);
                                var artist = db.Artist.FirstOrDefault(art => art.artId == album.albArtistId);
                                db.Artist.DeleteOnSubmit(artist);
                                db.SubmitChanges();
                                MessageBox.Show("Удалилось");
                                sUpdate();
                            }
                        }

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        var sortedSongs = db.Song_View.OrderBy(z => z.Название_песни);
                        bsSong_View.DataSource = sortedSongs;
                    }
                    else if (cbOrderBy.Text == "По убыванию")
                    {
                        var sortedSongs = db.Song_View.OrderByDescending(z => z.Название_песни);
                        bsSong_View.DataSource = sortedSongs;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var query = db.Song_View.Where(q => q.Название_песни == tbSearch.Text);
                    if (query.Any())
                    {
                        bsSong_View.DataSource = query;
                    }
                    else
                    {
                        MessageBox.Show("Ничего не найдено.");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void tsReset_Click(object sender, EventArgs e)
        {
            sUpdate();
        }
    }
}
