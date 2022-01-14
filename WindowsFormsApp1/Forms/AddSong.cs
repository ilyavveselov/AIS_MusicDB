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
    public partial class AddSong : Form
    {
        public AddSong()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var addSongName = tbSongName.Text;
            var addArtistName = tbArtistName.Text;
            var addAlbumName = tbAlbumName.Text;
            bool isArtist = false;
            bool isAlbum = false;
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    Table<Artist> artists = db.GetTable<Artist>();
                    Table<Album> albums = db.GetTable<Album>();
                    foreach (var a in albums)
                    {
                        if (a.albName == addAlbumName)
                        {
                            isAlbum = true;
                            break;
                        }
                    }
                    foreach (var art in artists)
                    {
                        if (art.artName == addArtistName)
                        {
                            isArtist = true;
                            break;
                        }

                    }
                    if (isArtist == false)
                    {
                        MessageBox.Show($"Артиста {addArtistName} нет в базе данных. Сейчас откроется форма для добавления артиста");
                        Hide();
                        AddArtist addArtist = new AddArtist();
                        addArtist.ShowDialog();
                        Show();
                    }
                    if (isAlbum == false)
                    {
                        MessageBox.Show($"Альбома {addAlbumName} нет в базе данных. Сейчас откроется форма для добавления альбома");
                        Hide();
                        AlbumAdd albumAdd = new AlbumAdd();
                        albumAdd.ShowDialog();
                        Show();
                    }
                    else
                    {
                        var album = db.Album.FirstOrDefault(a => a.albName == addAlbumName);
                        Guid albumId = album.albId;
                        var artist = db.Artist.FirstOrDefault(art => art.artName == addArtistName);
                        Guid artId = artist.artId;
                        Song song = new Song { songId = Guid.NewGuid(), songArtistId = artId, songAlbumId = albumId, songName = addSongName};
                        db.Song.InsertOnSubmit(song);
                        db.SubmitChanges();
                        MessageBox.Show($"Песня {addSongName} добавлена");
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
