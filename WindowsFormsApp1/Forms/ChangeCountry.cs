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

namespace WindowsFormsApp1.Forms
{
    public partial class ChangeCountry : Form
    {
        private Country Country;
        public ChangeCountry()
        {
            InitializeComponent();
            
        }
        public ChangeCountry(Country country):this()
        {
            this.Country = country;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    if (tbNewInfo.Text != "")
                    {
                        Country country = db.Country.FirstOrDefault(c => c.countryName == Country.countryName);
                        country.countryName = tbNewInfo.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Информация обновлена");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пусто...Пустотища! Что такое пустота? Это ничего...nothing...понимаете? " +
                            "Объект, который в себе имеет что-то, нельзя назвать пустым, верно? Поэтому, так как наш объект не пуст " +
                            "(иначе бы вы не смогли его изменять), пустотой заменить его информацию нельзя. Ничего не изменено.");
                    }
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }

        private void ChangeCountry_Load(object sender, EventArgs e)
        {
            tbNewInfo.Text = Country.countryName; 
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
