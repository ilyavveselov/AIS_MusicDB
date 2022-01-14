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
    public partial class AlbumAdd : Form
    {
        public AlbumAdd()
        {
            InitializeComponent();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            var artistName = tbAddAlbumArtist.Text;
            var albumName = tbAddAlbumAlbum.Text;
            var genreName = tbAddAlbumGenre.Text;
            var albumType = tbAddAlbumAlbType.Text;
            var labelName = tbAddAlbumLabelName.Text;
            var releaseDate = tbAddAlbumDate.Text;
            bool isArtName = false;
            bool isGenName = false;
            bool isAlbumType = false;
            bool isLabelName = false;
            using (MusicMixModelDataContext db = new MusicMixModelDataContext())
            {
                try
                {
                    Table<Artist> artists = db.GetTable<Artist>();
                    Table<Genre> genres = db.GetTable<Genre>();
                    Table<AlbumType> albumTypes = db.GetTable<AlbumType>();
                    Table<LabelName> labelNames = db.GetTable<LabelName>();
                    foreach (var art in artists)
                    {
                        if (art.artName == artistName)
                        {
                            isArtName = true;
                            break;
                        }
                    }
                    foreach (var gen in genres)
                    {
                        if (gen.genreName == genreName)
                        {
                            isGenName = true;
                            break;
                        }
                    }
                    foreach (var at in albumTypes)
                    {
                        if (at.albTypeName == albumType)
                        {
                            isAlbumType = true;
                            break;
                        }
                    }
                    foreach (var ln in labelNames)
                    {
                        if (ln.labelName1 == labelName)
                        {
                            isLabelName = true;
                            break;
                        }
                    }                 
                    if (isArtName == false)
                    {
                        MessageBox.Show($"Артиста {artistName} нет в базе данных. Сейчас откроется форма для добавления артиста");
                        Hide();
                        AddArtist addArtist = new AddArtist();
                        addArtist.ShowDialog();
                        Show();
                    }
                    if (isAlbumType == false)
                    {
                        MessageBox.Show($"Типа альбомов {albumType} нет в базе данных. Сейчас откроется форма для добавления типа альбомов");
                        Hide();
                        AddAlbumType aType = new AddAlbumType();
                        aType.ShowDialog();
                        Show();
                    }
                    if (isGenName == false)
                    {
                        MessageBox.Show($"Жанра {genreName} нет в базе данных. Сейчас откроется форма для добавления жанра");
                        Hide();
                        AddGenre addGenre = new AddGenre();
                        addGenre.ShowDialog();
                        Show();
                    }
                    if (isLabelName == false)
                    {
                        MessageBox.Show($"Лейбла {labelName} нет в базе данных. Сейчас откроется форма для добавления лейбла");
                        Hide();
                        AddLabelName addLabelName = new AddLabelName();
                        addLabelName.ShowDialog();
                        Show();
                    }
                    if (isArtName == true && isGenName == true && isAlbumType == true && isLabelName == true)
                    {
                        DateTime rlseDate = Convert.ToDateTime(releaseDate);
                        var artist = db.Artist.FirstOrDefault(a => a.artName == artistName);
                        var albumType1 = db.AlbumType.FirstOrDefault(aT => aT.albTypeName == albumType);
                        var labelName1 = db.LabelName.FirstOrDefault(l => l.labelName1 == labelName);
                        var genre = db.Genre.FirstOrDefault(g => g.genreName == genreName);
                        var artistId = artist.artId;
                        var aTypeId = albumType1.albTypeId;
                        var lNameId = labelName1.labelId;
                        var gId = genre.genreId;
                        Album album = new Album
                        {
                            albId = Guid.NewGuid(),
                            albArtistId = artistId,
                            albName = albumName,
                            albReleaseDate = rlseDate,
                            albTypeId = aTypeId,
                            albLabelId = lNameId,
                            albGenreId = gId
                        };
                        db.Album.InsertOnSubmit(album);
                        db.SubmitChanges();
                        MessageBox.Show($"Альбом {albumName} добавлен.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

