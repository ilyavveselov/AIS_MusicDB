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
    public partial class ucCountry : UserControl
    {
        private Country Country;
        public ucCountry()
        {
            InitializeComponent();
        }
        private void cChange()
        {
            ChangeCountry changeCountry = new ChangeCountry(Country);
            changeCountry.ShowDialog();
            cUpdate();
        }
        private void cUpdate()
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    bsCountry_View.DataSource = db.Country_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucCountry_Load(object sender, EventArgs e)
        {
            try
            {
                using (MusicMixModelDataContext db = new MusicMixModelDataContext())
                {
                    bsCountry_View.DataSource = db.Country_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            
        }

        private void bsCountry_View_CurrentChanged(object sender, EventArgs e)
        {
            if (bsCountry_View.Count == 0) return;
            else
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var sv = bsCountry_View.Current as Country_View;
                    Country = db.Country.FirstOrDefault(c => c.countryId == sv.cId);

                }
            }
        }

        private void tsChange_Click(object sender, EventArgs e)
        {
            cChange();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            AddCountry addCountry = new AddCountry();
            addCountry.ShowDialog();
            cUpdate();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Удаление страны приведет к удалению записей из других таблиц (Страна -> Артисты -> Альбомы -> Песни), которые содержат данный тип. Может, вы хотите изменить название страны?", "Сообщение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cChange();
            }
            else if (dialogResult == DialogResult.No)
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var countryName = Country.countryName;
                    var countryForDelete = db.Country.FirstOrDefault(c => c.countryName == countryName);
                    Guid cId = countryForDelete.countryId;
                    db.Country.DeleteOnSubmit(countryForDelete);
                    Table<Artist> artists = db.GetTable<Artist>();
                    List<Guid> artId = new List<Guid>();
                    foreach (var art in artists)
                    {
                        if (art.artCountryId == cId)
                        {
                            db.Artist.DeleteOnSubmit(art);
                            artId.Add(art.artId);
                        }
                    }
                    Table<Album> albums = db.GetTable<Album>();
                    List<Guid> aId = new List<Guid>();
                    for (int i = 0; i < artId.Count; i++)
                    {
                        foreach (var a in albums)
                        {
                            if (a.albArtistId == artId[i])
                            {
                                db.Album.DeleteOnSubmit(a);
                                aId.Add(a.albId);

                            }
                        }
                    }
                    Table<Song> songs = db.GetTable<Song>();
                    for (int i = 0; i < aId.Count; i++)
                    {
                        foreach (var s in songs)
                        {
                            if (s.songAlbumId == aId[i])
                            {
                                db.GetTable<Song>().DeleteOnSubmit(s);

                            }
                        }
                    }
                    DialogResult dialogForSure = MessageBox.Show("Вы уверены? Данная операция может стереть практически все записи.", "Сообщение", MessageBoxButtons.YesNo);
                    if (dialogForSure == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        cUpdate();
                    }
                    else if (dialogForSure == DialogResult.No)
                    {
                        MessageBox.Show("Удаление отменено");
                        cUpdate();
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
                        var sortedCountries = db.Country_View.OrderBy(z => z.Страна);
                        bsCountry_View.DataSource = sortedCountries;
                    }
                    else if (cbOrderBy.Text == "По убыванию")
                    {
                        var sortedCountries = db.Country_View.OrderByDescending(z => z.Страна);
                        bsCountry_View.DataSource = sortedCountries;
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
                    var query = db.Country_View.Where(q => q.Страна == tbSearch.Text);
                    if (query.Any())
                    {
                        bsCountry_View.DataSource = query;
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

        private void tsReset_Click(object sender, EventArgs e)
        {
            cUpdate();
        }
    }
}
