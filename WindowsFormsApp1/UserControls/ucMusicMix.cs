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
    public partial class ucMusicMix : UserControl
    {
        private string filter;
        public ucMusicMix()
        {
            InitializeComponent();
        }

        private void ucMusicMix_Load(object sender, EventArgs e)
        {
            using (MusicMixModelDataContext db = new MusicMixModelDataContext())
            {
                cbArtists.DataSource = db.Artist_View;
                cbGenres.DataSource = db.Genre_View;
                if (db.MusicMix.FirstOrDefault() != null)
                {
                    Table<MusicMix> mmix = db.GetTable<MusicMix>();
                    foreach (var m in mmix)
                    {
                        db.GetTable<MusicMix>().DeleteOnSubmit(m);
                        db.SubmitChanges();
                    }
                }
            }
        }

        private void cbGorA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGorA.Text == "По жанрам")
            {
                cbGenres.Visible = !cbGenres.Visible;
                cbArtists.Visible = false;
            }
            else
            {
                cbArtists.Visible = !cbArtists.Visible;
                cbGenres.Visible = false;
            }
        }

        private void lCreate_Click(object sender, EventArgs e)
        {
            if (cbGorA.Text == "По исполнителям")
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var searchArtist = db.Artist.FirstOrDefault(art => art.artName == cbArtists.Text);
                    var searchAlbum = db.Album.FirstOrDefault(a => a.albArtistId == searchArtist.artId);
                    var searchGenre = db.Genre.FirstOrDefault(g => g.genreId == searchAlbum.albGenreId);
                    filter = searchGenre.genreName;
                        
                }
            }
            else
            {
                filter = cbGenres.Text;
            }
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var genre = (from g in db.Genre where g.genreName == filter select g).Single<Genre>();
                    Guid genreId = genre.genreId;
                    Table<Album> albums = db.GetTable<Album>();
                    Table<Song> songs = db.GetTable<Song>();
                    Table<Artist> artists = db.GetTable<Artist>();
                    Table<MusicMix> musicMix = db.GetTable<MusicMix>();
                    List<Guid> albId = new List<Guid>();
                    List<Guid> sId = new List<Guid>();
                    Dictionary<Guid, Guid> sA = new Dictionary<Guid, Guid>();
                    var user = (from u in db.User where u.usrOnline == 1 select u).Single<User>();
                    Guid uId = user.usrId;
                    foreach (var a in albums)
                    {
                        if (a.albGenreId == genreId)
                        {
                            albId.Add(a.albId);
                        }
                    }
                    foreach (var s in songs)
                    {
                        for (int i = 0; i < albId.Count; i++)
                        {
                            if (s.songAlbumId == albId[i])
                            {
                                sId.Add(s.songId);
                                sA.Add(s.songId, albId[i]);
                            }
                        }
                    }

                    for (int i = 0; i < sId.Count; i++)
                    {
                        var id = (from a in db.Album where a.albId == sA[sId[i]] select a).Single<Album>();
                        Guid artId = id.albArtistId;
                        MusicMix mix = new MusicMix
                        {
                            musicMixSongPositionId = Guid.NewGuid(),
                            musicMixAlbumId = sA[sId[i]],
                            musicMixArtistId = artId,
                            musicMixGenreId = genreId,
                            musicMixSongId = sId[i],
                            musicMixUserId = uId
                        };
                        db.GetTable<MusicMix>().InsertOnSubmit(mix);
                        db.SubmitChanges();
                    }
                    
                    MessageBox.Show("Список готов");
                    dgvMusicMix.DataSource = db.MusicMix_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void lSave_Click(object sender, EventArgs e)
        {
            using (var db = new MusicMixModelDataContext())
            {
                Table<MusicMix> musicMix = db.GetTable<MusicMix>();
                Table<OldMusicMix> oldMusic = db.GetTable<OldMusicMix>();
                List<Guid> mmId = new List<Guid>();
                List<Guid> spId = new List<Guid>();
                List<Guid> uId = new List<Guid>();
                int numberOfList;
                if ((db.OldMusicMix.OrderByDescending(x => x.oldMixSongPositionId).FirstOrDefault()) == null)
                {
                    numberOfList = 0;
                }
                else
                {
                    numberOfList = db.OldMusicMix.OrderByDescending(x => x.oldMixIdOfList).FirstOrDefault().oldMixIdOfList;
                }
                foreach (var mm in musicMix)
                {
                    mmId.Add(mm.musicMixSongId);
                    spId.Add(mm.musicMixSongPositionId);
                    uId.Add(mm.musicMixUserId);
                }
                for (int i = 0; i < mmId.Count; i++)
                {
                    OldMusicMix newOldMM = new OldMusicMix {
                        oldMixId = Guid.NewGuid(),
                        oldMixSongId = mmId[i],
                        oldMixSongPositionId = spId[i],
                        oldMixUserId = uId[i],
                        oldMixIdOfList = numberOfList + 1
                    };
                    db.OldMusicMix.InsertOnSubmit(newOldMM);
                    db.SubmitChanges();
                }
                filter = cbGenres.Text;
                var genre = (from g in db.Genre where g.genreName == filter select g).Single<Genre>();
                Guid genreId = genre.genreId;
                foreach (var m in musicMix)
                {
                    var sPos = m.musicMixSongPositionId;
                    var mixForDelete = db.MusicMix.FirstOrDefault(x => x.musicMixSongPositionId == sPos);
                    db.MusicMix.DeleteOnSubmit(mixForDelete);
                    db.SubmitChanges();
                }
                MessageBox.Show("Список сохранен");
                
                
            }
        }

        private void lOld_Click(object sender, EventArgs e)
        {
            OldMixForm oldMixForm = new OldMixForm();
            oldMixForm.ShowDialog();
        }
    }
}
