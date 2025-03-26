using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemonMaxwellGameLevelCreator
{
    public class WallBox : WallBase
    {
        public RectangleF MyRect;
        public bool MoveableX = false;
        public bool MoveableY = false;
        Vect2 _Vel;
        double _fMass;

        public WallBox(RectangleF myRect, bool bBounceOffCorners, bool moveableX, bool moveableY, bool removable) : base()
        {
            MyRect = myRect;
            _bBounceOffCorners = bBounceOffCorners;
            MoveableX = moveableX;
            MoveableY = moveableY;
            _Vel = new Vect2(0.0, 0.0);
            _fMass = 100000.0;
            _bRemovable = removable;
        }

        public override void Draw(Graphics g, bool bSelected)
        {
            float w = Form1._rectBounds.Width;
            float h = Form1._rectBounds.Height;
            float x = Form1._rectBounds.X;
            float y = Form1._rectBounds.Y;
            g.FillRectangle(new SolidBrush(bSelected ? Color.Red : DrawColour), MyRect.X * w + x, MyRect.Y * h + y, MyRect.Width * w, MyRect.Height * h);
            if (bSelected)
            {
                Pen pen = new Pen(DrawColour, 5.0f);
                g.DrawRectangle(pen, MyRect.X * w + x, MyRect.Y * h + y, MyRect.Width * w, MyRect.Height * h);
            }
        }
    }
}

