using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodAdaptasyonProblemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            DusmanRobotu dusmanRobotu = new DusmanRobotu();
            Adaptor adaptor = new Adaptor(dusmanRobotu);
            adaptor.DusmanAdi();
            adaptor.Hizlan();
            adaptor.SilahKullan();
            DusmanTank dusmanTank = new DusmanTank();
            dusmanTank.DusmanAdi();
            dusmanTank.Hizlan();
            dusmanTank.SilahKullan();
        }
    }
}
