using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLostNFurious
{
    
    class Bloc
    {
        int x;
        int y;

        public Bloc() :this(10, 10)
        {

        }

        public Bloc(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, x, y, GameConstant.TAILLE_BLOC_X, GameConstant.TAILLE_BLOC_Y);
        }

        public PointF Position
        {
            get
            {
                return new PointF((float)x, (float)y);
            }
        }
    }

    class Bordure : Bloc
    {
        int x, y;

        public Bordure(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LightBlue, x, y, GameConstant.TAILLE_BLOC_X, GameConstant.TAILLE_BLOC_Y);
        }
    }

    class Arrivee : Bloc
    {
        int x, y;

        public Arrivee(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }

        public Arrivee()
        {

        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, x, y, GameConstant.TAILLE_BLOC_X, GameConstant.TAILLE_BLOC_Y);
        }
    }
}
