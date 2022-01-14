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
namespace WindowsFormsApp1.UserControls
{
    public partial class ucOldMix : UserControl
    {
        private OldMusicMix OldMusicMix;
        public ucOldMix()
        {
            InitializeComponent();
        }

        private void ucOldMix_Load(object sender, EventArgs e)
        {
            using (var db = new MusicMixModelDataContext())
            {
                bsList.DataSource = db.List_View;
            }
            
        }

        private void bsList_CurrentChanged(object sender, EventArgs e)
        {
            if (bsList.Count == 0) return;
            else
            {
                using (var db = new MusicMixModelDataContext())
                {
                    var sv = bsList.Current as List_View;
                    OldMusicMix = db.OldMusicMix.FirstOrDefault(x => x.oldMixId == sv.oMId);
                }
            }
        }

        private void tsOpen_Click(object sender, EventArgs e)
        {
            OpenOldMix openOldMix = new OpenOldMix(OldMusicMix);
            openOldMix.ShowDialog();
        }
    }
}
