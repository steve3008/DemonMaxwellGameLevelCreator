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
    public class WallHorizontal : WallBase
    {
        public double Left, Right, Y;

        public WallHorizontal(double left, double right, double y, bool bFinStart, bool bFinEnd, bool removable) : base()
        {
            Left = left;
            Right = right;
            Y = y;
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
            g.DrawLine(pen, _bFiniteStart ? (float)Left * w + x : Form1._rectBounds.Left, (float)Y * h + y,
                            _bFiniteEnd ? (float)Right * w + x : Form1._rectBounds.Right, (float)Y * h + y);
        }
    }
}
