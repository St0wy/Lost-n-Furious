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

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Bloc() :this(10, 10)
        {

        }

        public Bloc(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public PointF Position
        {
            get
            {
                return new PointF((float)X, (float)Y);
            }
        }

        
    }

    class Bordure : Bloc
    {
        int x;
        int y;

        public Bordure(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Arrivee : Bloc
    {
        int x;
        int y;
        bool isActive;

        public bool IsActive { get => isActive; set => isActive = value; }

        public Arrivee(int x, int y) : base(x, y)
        {
            this.x = x;
            this.y = y;
            IsActive = false;
        }

        public Arrivee()
        {

        }

        public void Activate()
        {
            IsActive = true;
        }

        public void Desactivate()
        {
            IsActive = false;
        }
    }
}
