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
    public partial class AddArtist : Form
    {
        public AddArtist()
        {
            InitializeComponent();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            var addName = tbAddArtistName.Text;
            var addCountry = tbAddCountry.Text;
            bool isCountry = false;
            try
            {
                using (MusicMixModelDataContext db = new MusicMixModelDataContext())
                {
                    Table<Country> countries = db.GetTable<Country>();
                    foreach (var c in countries)
                    {
                        if (c.countryName == addCountry)
                        {
                            isCountry = true;
                            break;
                        }
                    }
                    if (isCountry == false)
                    {
                        MessageBox.Show($"Страны {addCountry} нет в базе данных. Сейчас откроется форма для добавления страны");
                        Hide();
                        AddCountry addCountry1 = new AddCountry();
                        addCountry1.ShowDialog();
                        Show();
                    }
                    else
                    {
                        var cntry = db.Country.FirstOrDefault(c => c.countryName == addCountry);
                        Guid countryId = cntry.countryId;
                        Artist artist = new Artist { artId = Guid.NewGuid(), artName = addName, artCountryId = countryId };
                        db.Artist.InsertOnSubmit(artist);
                        db.SubmitChanges();
                        MessageBox.Show($"Артист {addName} добавлен");
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
