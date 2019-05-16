using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodAdaptasyonProblemi
{
    public class Adaptor:IDusman
    {
        DusmanRobotu dusmanRobotu;
        public Adaptor(DusmanRobotu dusmanrobotu)
        {
            this.dusmanRobotu = dusmanrobotu;
        }
        public void SilahKullan()
        {
            dusmanRobotu.YumrukAt();
        }
        public void Hizlan()
        {
            dusmanRobotu.Yuru();
        }
        public void DusmanAdi()
        {
            dusmanRobotu.RobotIsim();
        }

    }
}
