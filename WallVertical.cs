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
    public class WallVertical : WallBase
    {
        public double Top, Bottom, X;

        public WallVertical(double top, double bottom, double x, bool bFinStart, bool bFinEnd, bool removable) : base()
        {
            Top = top;
            Bottom = bottom;
            X = x;
            _bFiniteStart = bFinStart;
            _bFiniteEnd = bFinEnd;
            _bRemovable = removable;
        }

        public override void Draw(Graphics g, bool bSelected)
        {
            float w = Form1._rectBounds.Width;
            float h = Form1._rectBounds.Height;
            float x = Form1._rectBounds.X;
            float y = Form1._rectBounds.Y;
            Pen pen = bSelected ? new Pen(DrawColour, 5.0f) : new Pen(DrawColour);
            g.DrawLine(pen, (float)X * w + x, _bFiniteStart ? (float)Top * h + y : Form1._rectBounds.Top,
                            (float)X * w + x, _bFiniteEnd ? (float)Bottom * h + y : Form1._rectBounds.Bottom);
        }
    }
}
