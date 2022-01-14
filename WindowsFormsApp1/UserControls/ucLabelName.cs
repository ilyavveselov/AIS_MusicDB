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
namespace WindowsFormsApp1.UserControls
{
    public partial class ucLabelName : UserControl
    {
        private LabelName LabelName;
        public ucLabelName()
        {
            InitializeComponent();
        }
        private void lNUpdate()
        {
            using (var db = new MusicMixModelDataContext())
            {
                bsLabelName_View.DataSource = db.LabelName_View;
            }
        }
        private void lNChange()
        {
            ChangeLabelName changeLabelName = new ChangeLabelName(LabelName);
            changeLabelName.ShowDialog();
            lNUpdate();
        }

        private void ucLabelName_Load(object sender, EventArgs e)
        {
            try
            {
                using (MusicMixModelDataContext db = new MusicMixModelDataContext())
                {
                    bsLabelName_View.DataSource = db.LabelName_View;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }

        private void bsLabelName_View_CurrentChanged(object sender, EventArgs e)
        {
            if (bsLabelName_View.Count == 0) return;
            else
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var sv = bsLabelName_View.Current as LabelName_View;
                    LabelName = db.LabelName.FirstOrDefault(x => x.labelId == sv.lId);

                }
            }
        }

        private void tsChange_Click(object sender, EventArgs e)
        {
            lNChange();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            AddLabelName addLabelName = new AddLabelName();
            addLabelName.ShowDialog();
            lNUpdate();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
               "Удаление лейбла приведет к удалению записей из других таблиц (Лейбл -> Альбомы -> Песни), которые содержат данный тип. Может, вы хотите изменить название лейбла?", "Сообщение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lNChange();
            }
            else if (dialogResult == DialogResult.No)
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var labelName = LabelName.labelName1;
                    var lName = db.LabelName.FirstOrDefault(lN => lN.labelName1 == labelName);
                    Guid lnId = lName.labelId;
                    db.LabelName.DeleteOnSubmit(lName);
                    Table<Album> albums = db.GetTable<Album>();
                    List<Guid> aId = new List<Guid>();
                    foreach (var a in albums)
                    {
                        if (a.albLabelId == lnId)
                        {
                            db.Album.DeleteOnSubmit(a);
                            aId.Add(a.albId);

                        }
                    }
                    Table<Song> songs = db.GetTable<Song>();
                    for (int i = 0; i < aId.Count; i++)
                    {
                        foreach (var s in songs)
                        {
                            if (s.songAlbumId == aId[i])
                            {
                                db.Song.DeleteOnSubmit(s);

                            }
                        }
                    }
                    DialogResult dialogForSure = MessageBox.Show("Вы уверены? Данная операция может стереть практически все записи.", "Сообщение", MessageBoxButtons.YesNo);
                    if (dialogForSure == DialogResult.Yes)
                    {
                        db.SubmitChanges();
                        lNUpdate();
                    }
                    else if (dialogForSure == DialogResult.No)
                    {
                        MessageBox.Show("Удаление отменено");
                        lNUpdate();
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
                        var sortedLabelName = db.LabelName_View.OrderBy(z => z.Название_лейбла);
                        bsLabelName_View.DataSource = sortedLabelName;
                    }
                    else if (cbOrderBy.Text == "По убыванию")
                    {
                        var sortedLabelName = db.LabelName_View.OrderByDescending(z => z.Название_лейбла);
                        bsLabelName_View.DataSource = sortedLabelName;
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
                    var query = db.LabelName_View.Where(q => q.Название_лейбла == tbSearch.Text);
                    if (query.Any())
                    {
                        bsLabelName_View.DataSource = query;
                    }
                    else
                    {
                        MessageBox.Show("Ничего не найдено.");
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsReset_Click(object sender, EventArgs e)
        {
            lNUpdate();
        }
    }
}
