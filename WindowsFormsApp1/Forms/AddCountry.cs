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
    public partial class AddCountry : Form
    {
        public AddCountry()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addName = txtboxAdd.Text;
            bool isInDb = false;

            try
            {
                using (MusicMixModelDataContext db = new MusicMixModelDataContext())
                {
                    Table<Country> countries = db.GetTable<Country>();
                    foreach (var c in countries)
                    {
                        if (c.countryName == addName)
                        {
                            isInDb = true;
                            MessageBox.Show($"Страна {addName} уже существует.");
                            break;
                        }
                    }
                    if (isInDb == false)
                    {
                        Country country = new Country { countryId = Guid.NewGuid(), countryName = addName.ToString() };
                        db.Country.InsertOnSubmit(country);
                        db.SubmitChanges();
                        MessageBox.Show($"Страна {addName} добавлена.");
                        this.Close();
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
