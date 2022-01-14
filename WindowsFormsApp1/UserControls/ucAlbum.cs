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
    public partial class ucAlbum : UserControl
    {
        private Album Album;

        public ucAlbum()
        {
            InitializeComponent();
        }
        private void aChange()
        {
            ChangeAlbum changeAlbum = new ChangeAlbum(Album);
            changeAlbum.ShowDialog();
            aUpdate();
        }
        private void aUpdate()
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    bsAlbum_View.DataSource = db.Album_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucAlbum_Load(object sender, EventArgs e)
        {
            using(MusicMixModelDataContext db = new MusicMixModelDataContext())
            {
                bsAlbum_View.DataSource = db.Album_View;
            }

        }

        private void tsChange_Click(object sender, EventArgs e)
        {
            aChange();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            AlbumAdd albumAdd = new AlbumAdd();
            albumAdd.ShowDialog();
            aUpdate();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                "Удаление альбома приведет к удалению записей из других таблиц, которые содержат данный альбом. Может, вы хотите изменить название или дату выхода альбома?", "Сообщение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    aChange();
                }
                else if (dialogResult == DialogResult.No)
                {
                    using (var db = new MusicMixModelDataContext())
                    {
                        var albumName = Album.albName;
                        var album = db.Album.FirstOrDefault(a => a.albName == albumName);
                        Guid albId = album.albId;
                        db.Album.DeleteOnSubmit(album);
                        Table<Song> songs = db.GetTable<Song>();
                        foreach (var s in songs)
                        {
                            if (s.songAlbumId == albId)
                            {
                                db.Song.DeleteOnSubmit(s);
                            }
                        }
                        db.SubmitChanges();
                        aUpdate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void tsFilter_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    Table<Album> albums = db.GetTable<Album>();
                    if (tsCmbBxAlbumFilter.Text.ToString() == "По возрастанию...")
                    {
                        var sortedAlbums = db.Album_View.OrderBy(z => z.Альбом);                      
                        bsAlbum_View.DataSource = sortedAlbums;
                    }
                    else if(tsCmbBxAlbumFilter.Text == "По убыванию...")
                    {
                        var sortedAlbums = db.Album_View.OrderByDescending(z => z.Альбом);
                        bsAlbum_View.DataSource = sortedAlbums;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            
            try
            {
                var searchText = tsTBoxSearch.Text;
                using (var db = new MusicMixModelDataContext())
                {
                    var query = db.Album_View.Where(z => z.Альбом == searchText);
                    if (query.Any())
                    {
                        bsAlbum_View.DataSource = query;
                        
                    }
                    else
                    {
                        MessageBox.Show("Ничего не найдено");
                    }
                }
                tsTBoxSearch.Clear();
            } 
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }
        private void tsReset_Click(object sender, EventArgs e)
        {
            aUpdate();

        }

        private void bsAlbum_View_CurrentChanged(object sender, EventArgs e)
        {
            if (bsAlbum_View.Count == 0)
            {
                return;
            }
            using (var db = new MusicMixModelDataContext())
            {
                var sv = bsAlbum_View.Current as Album_View;
                Album = db.Album.FirstOrDefault(x => x.albId == sv.albId);

            }
        }
    }
}
