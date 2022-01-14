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
    public partial class ChangeLabelName : Form
    {
        private LabelName LabelName;
        public ChangeLabelName()
        {
            InitializeComponent();
        }
        public ChangeLabelName(LabelName labelName):this()
        {
            this.LabelName = labelName;
        }
        private void ChangeLabelName_Load(object sender, EventArgs e)
        {
            tbNewInfo.Text = LabelName.labelName1;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    if (tbNewInfo.Text!="")
                    {
                        var lName = db.LabelName.FirstOrDefault(l => l.labelName1 == LabelName.labelName1);
                        lName.labelName1 = tbNewInfo.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Информация обновлена");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Пусто!Ничего не изменено.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
