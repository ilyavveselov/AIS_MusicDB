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
    public partial class AddLabelName : Form
    {
        public AddLabelName()
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
                    Table<LabelName> labelNames = db.GetTable<LabelName>();
                    foreach (var ln in labelNames)
                    {
                        if (ln.labelName1 == addName)
                        {
                            isInDb = true;
                            MessageBox.Show($"Лейбл {addName} уже существует.");
                            break;
                        }
                    }
                    if (isInDb == false)
                    {
                        LabelName labelName = new LabelName { labelId = Guid.NewGuid(), labelName1 = addName.ToString() };
                        db.LabelName.InsertOnSubmit(labelName);
                        db.SubmitChanges();
                        MessageBox.Show($"Лейбл {addName} добавлен.");
                        txtboxAdd.ReadOnly = true;
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
