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
    public partial class AddAlbumType : Form
    {
        public AddAlbumType()
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
                    Table<AlbumType> albumTypes = db.GetTable<AlbumType>();
                    foreach (var at in albumTypes)
                    {
                        if (at.albTypeName == addName)
                        {
                            isInDb = true;
                            MessageBox.Show($"Тип альбома {addName} уже существует.");
                            break;
                        }
                    }
                    if (isInDb == false)
                    {
                        AlbumType albumType = new AlbumType { albTypeId = Guid.NewGuid(), albTypeName = addName.ToString() };
                        db.GetTable<AlbumType>().InsertOnSubmit(albumType);
                        db.SubmitChanges();
                        MessageBox.Show($"Тип альбома {addName} добавлен.");
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