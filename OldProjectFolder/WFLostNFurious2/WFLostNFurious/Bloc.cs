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
        bool isActive;

        public Arrivee(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
            isActive = false;
        }

        public Arrivee()
        {

        }

        public void Activate()
        {
            isActive = true;
        }

        public void Desactivate()
        {
            isActive = false;
        }

        public override void Paint(object sender, PaintEventArgs e)
        {
            if (isActive)
            {
                e.Graphics.FillRectangle(Brushes.Red, x, y, GameConstant.TAILLE_BLOC_X, GameConstant.TAILLE_BLOC_Y);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Black, x, y, GameConstant.TAILLE_BLOC_X, GameConstant.TAILLE_BLOC_Y);
            }
        }
    }
}
