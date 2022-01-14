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
namespace WindowsFormsApp1.Forms
{
    public partial class OpenOldMix : Form
    {
        private OldMusicMix OldMusicMix;
        public OpenOldMix()
        {
            InitializeComponent();
        }
        public OpenOldMix(OldMusicMix oldMusicMix):this()
        {
            this.OldMusicMix = oldMusicMix;
        }

        private void OpenOldMix_Load(object sender, EventArgs e)
        {
            using (MusicMixModelDataContext db = new MusicMixModelDataContext())
            {
                dgvOld_View.DataSource = db.MusicMix_View;
                Table<MusicMix> musicMixes = db.GetTable<MusicMix>();
                foreach (var mm in musicMixes)
                {
                    db.MusicMix.DeleteOnSubmit(mm);
                    db.SubmitChanges();
                }
            }
        }

        private void OpenOldMix_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var db = new MusicMixModelDataContext())
            {
                Table<MusicMix> musicMixes = db.GetTable<MusicMix>();
                foreach (var mm in musicMixes)
                {
                    db.MusicMix.DeleteOnSubmit(mm);
                    db.SubmitChanges();
                }
            }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            using (var db = new MusicMixModelDataContext())
            {
                List<Guid> oId = new List<Guid>();
                Table<Song> songs = db.GetTable<Song>();
                Table<OldMusicMix> oldMusicMixes = db.GetTable<OldMusicMix>();
                foreach (var o in oldMusicMixes)
                {
                    if (o.oldMixUserId == OldMusicMix.oldMixUserId && o.oldMixIdOfList == OldMusicMix.oldMixIdOfList)
                    {
                        oId.Add(o.oldMixSongId);
                    }
                }
                List<Guid> sId = new List<Guid>();
                List<Guid> aId = new List<Guid>();
                List<Guid> artId = new List<Guid>();
                for (int i = 0; i < oId.Count; i++)
                {
                    foreach (var s in songs)
                    {
                        if (s.songId == oId[i])
                        {
                            sId.Add(s.songId);
                            aId.Add(s.songAlbumId);
                            artId.Add(s.songArtistId);
                        }
                    }

                }
                Guid genreId = db.Genre.FirstOrDefault(x => x.genreId == (db.Album.FirstOrDefault(y => y.albId == aId[0]).albGenreId)).genreId;
                Guid usrId = db.User.FirstOrDefault(x => x.usrOnline == 1).usrId;
                for (int i = 0; i < sId.Count; i++)
                {
                    MusicMix mix = new MusicMix
                    {
                        musicMixSongPositionId = Guid.NewGuid(),
                        musicMixAlbumId = aId[i],
                        musicMixArtistId = artId[i],
                        musicMixGenreId = genreId,
                        musicMixSongId = sId[i],
                        musicMixUserId = usrId
                    };
                    db.MusicMix.InsertOnSubmit(mix);
                    db.SubmitChanges();

                }
                dgvOld_View.DataSource = db.MusicMix_View;
            }
        }
    }
}
