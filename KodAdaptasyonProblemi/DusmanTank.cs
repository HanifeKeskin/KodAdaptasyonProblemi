using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodAdaptasyonProblemi
{
    public class DusmanTank:IDusman
    {
        public void SilahKullan()
        {
            System.Windows.Forms.MessageBox.Show("Düşman Tankı Ateş Ediyor..");
        }

        public void Hizlan()
        {
            System.Windows.Forms.MessageBox.Show("Düşman Tankı Hızlanıyor..");
        }
        public void DusmanAdi()
        {
            System.Windows.Forms.MessageBox.Show("Düşman Tankı HFTTF..");
        }

    }
}
