using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLostNFurious
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Bloc mur = new Bloc(10, 50);
            mur.Paint(sender, e);

            Bloc mur2 = new Bloc(10, 30);
            mur2.Paint(sender, e);

            Bordure bordure1 = new Bordure(10, 10);
            bordure1.Paint(sender, e);

            Arrivee arrivee1 = new Arrivee(70, 70);
            arrivee1.Paint(sender, e);
        }
    }
}
