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
    public partial class ucArtist : UserControl
    {
        private Artist Artist;

        public ucArtist()
        {
            InitializeComponent();
        }
        private void artChange()
        {
            ChangeArtist changeArtist = new ChangeArtist(Artist);
            changeArtist.ShowDialog();
            artUpdate();
        }
        private void artUpdate()
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    bsArtist_View.DataSource = db.Artist_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsChange_Click(object sender, EventArgs e)
        {
            artChange();
        }

        private void bsArtist_View_CurrentChanged(object sender, EventArgs e)
        {
            if (bsArtist_View.Count == 0) return;
            else
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var sv = bsArtist_View.Current as Artist_View;
                    Artist = db.Artist.FirstOrDefault(art => art.artId == sv.artId);
                }
            }
        }

        private void ucArtist_Load(object sender, EventArgs e)
        {
            try
            {
                using (MusicMixModelDataContext db = new MusicMixModelDataContext())
                {
                    bsArtist_View.DataSource = db.Artist_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            AddArtist addArtist = new AddArtist();
            addArtist.ShowDialog();
            artUpdate();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            try
            {
                    DialogResult dialogResult = MessageBox.Show(
               "Удаление артиста приведет к удалению записей из других таблиц (Артист -> Альбомы -> Песни), которые содержат данный тип. Может, вы хотите изменить название типа альбома?", "Сообщение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        artChange();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        using (var db = new MusicMixModelDataContext())
                        {
                            var artName = Artist.artName;
                            var art = db.Artist.FirstOrDefault(a => a.artName == artName);
                            Guid artId = art.artId;
                            db.Artist.DeleteOnSubmit(art);
                            Table<Album> albums = db.GetTable<Album>();
                            List<Guid> aId = new List<Guid>();
                            foreach (var a in albums)
                            {
                                if (a.albArtistId == artId)
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
                                artUpdate();
                            }
                            else if (dialogForSure == DialogResult.No)
                            {
                                MessageBox.Show("Удаление отменено");
                                artUpdate();
                            }
                        }
                    }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
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
                        var sortedArtist = db.Artist_View.OrderBy(sA=>sA.Исполнитель);
                        bsArtist_View.DataSource = sortedArtist;
                        
                    }
                    else if (cbOrderBy.Text == "По убыванию")
                    {
                        var sortedArtist = db.Artist_View.OrderByDescending(sA => sA.Исполнитель);
                        bsArtist_View.DataSource = sortedArtist;
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
            artUpdate();
        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var query = db.Artist_View.Where(q => q.Исполнитель == tbSearch.Text);
                    if (query.Any())
                    {
                        bsArtist_View.DataSource = query; 
                    }
                    else
                    {
                        MessageBox.Show("Пусто! Ничего не найдено.");
                    }
                    tbSearch.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
