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
    public partial class ucAlbumType : UserControl
    {
        private AlbumType AlbumType;
        private void aTUpdate()
        {
            using (var db = new MusicMixModelDataContext())
            {
                bsAlbumType.DataSource = db.AlbumType_View;
            }
        }
        private void aTChange()
        {
            ChangeAlbumType changeAlbumType = new ChangeAlbumType(AlbumType);
            changeAlbumType.ShowDialog();
            aTUpdate();
        }

        public ucAlbumType()
        {
            InitializeComponent();
        }

        private void ucAlbumType_Load(object sender, EventArgs e)
        {
            using (MusicMixModelDataContext db = new MusicMixModelDataContext())
            {
                bsAlbumType.DataSource = db.AlbumType_View;
            }
        }

        private void bsAlbumType_CurrentChanged(object sender, EventArgs e)
        {
            if (bsAlbumType.Count == 0) return;
            using (var db = new MusicMixModelDataContext())
            {
                var sv = bsAlbumType.Current as AlbumType_View;
                AlbumType = db.AlbumType.FirstOrDefault(aT => aT.albTypeId == sv.aTypeId);
            }
        }

        private void tsChange_Click(object sender, EventArgs e)
        {
            aTChange();
            aTUpdate();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            AddAlbumType addAlbumType = new AddAlbumType();
            addAlbumType.ShowDialog();
            aTUpdate();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Удаление типа альбома приведет к удалению записей из других таблиц (Тип альбома -> Альбомы -> Песни), которые содержат данный тип. Может, вы хотите изменить название типа альбома?", "Сообщение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                aTChange();
            }
            else if (dialogResult == DialogResult.No)
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var albumTypeName = AlbumType.albTypeName;
                    var albType = db.AlbumType.FirstOrDefault(aT => aT.albTypeName == albumTypeName);
                    Guid albTId = albType.albTypeId;
                    db.AlbumType.DeleteOnSubmit(albType);
                    Table<Album> albums = db.GetTable<Album>();
                    List<Guid> aId = new List<Guid>();
                    foreach (var a in albums)
                    {
                        if (a.albTypeId == albTId)
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
                        aTUpdate();
                    }
                    else if(dialogForSure == DialogResult.No)
                    {
                        MessageBox.Show("Удаление отменено");
                        aTUpdate();
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
                        var sortedAlbumTypes = db.AlbumType_View.OrderBy(z => z.Тип_альбома);
                        bsAlbumType.DataSource = sortedAlbumTypes;
                    }
                    else if (cbOrderBy.Text == "По убыванию")
                    {
                        var sortedAlbumTypes = db.AlbumType_View.OrderByDescending(z => z.Тип_альбома);
                        bsAlbumType.DataSource = sortedAlbumTypes;
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
            aTUpdate();
        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var query = db.AlbumType_View.Where(q=>q.Тип_альбома == tbSearch.Text);
                    if (query.Any())
                    {
                        bsAlbumType.DataSource = query;
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
    }
}
