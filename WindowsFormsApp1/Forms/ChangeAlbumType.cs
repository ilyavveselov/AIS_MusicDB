using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1.Forms
{
    public partial class ChangeAlbumType : Form
    {
        private AlbumType AlbumType;
        public ChangeAlbumType()
        {
            InitializeComponent();
        }
        public ChangeAlbumType(AlbumType albumType): this()
        {
            this.AlbumType = albumType;
        }


        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                    {
                    if (tbNewInfo.Text != "")
                    {
                        AlbumType aType = db.AlbumType.FirstOrDefault(aT=>aT.albTypeName == AlbumType.albTypeName);
                        aType.albTypeName = tbNewInfo.Text;
                        MessageBox.Show("Информация обновлена");
                        db.SubmitChanges();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Ничего не изменилось. Это было бессмысленно...");
                    }
                    
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void ChangeAlbumType_Load(object sender, EventArgs e)
        {
            tbNewInfo.Text = AlbumType.albTypeName;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
