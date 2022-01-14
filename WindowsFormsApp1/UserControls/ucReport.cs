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
namespace WindowsFormsApp1.UserControls
{
    public partial class ucReport : UserControl
    {
        public ucReport()
        {
            InitializeComponent();
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            using (var db = new MusicMixModelDataContext())
            {
                bsAlbum_View.DataSource = db.Album_View;
                report1.Load("AlbumReport.frx");
                report1.Show();
            }

        }
    }
}
