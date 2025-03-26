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
    public class WallParabola : WallBase
    {
        //public Vect2 _Focus;


        public RectangleF _Bounds;
        private PointF[] _Path;

        public WallParabola(RectangleF bounds, bool removable) : base()
        {
            _Bounds = bounds;
            _bRemovable = removable;
        }

        public void SetPoints()
        {
            int iLastPnt = Math.Min(Math.Max((int)(_Bounds.Width * 79.0f), 4), 79);
            float x = -1.0f;
            float xStep = 2.0f / (float)iLastPnt;
            _Path = new PointF[iLastPnt + 1];
            for (int i = 0; i <= iLastPnt; i++)
            {
                float y = x * x;
                _Path[i].X = (x * 0.5f + 0.5f) * _Bounds.Width + _Bounds.X;
                _Path[i].Y = y * _Bounds.Height + _Bounds.Y;
                x += xStep;
            }
        }

        public override void Draw(Graphics g, bool bSelected)
        {
            SetPoints();
            float w = Form1._rectBounds.Width;
            float h = Form1._rectBounds.Height;
            float x = Form1._rectBounds.X;
            float y = Form1._rectBounds.Y;
            PointF[] pathScaled = new PointF[_Path.Length];
            for (int i = 0; i < _Path.Length; i++)
            {
                pathScaled[i] = new PointF(_Path[i].X * w + x, _Path[i].Y * h + y);
            }
            Pen pen = bSelected ? new Pen(DrawColour, 5.0f) : new Pen(DrawColour);
            g.DrawLines(pen, pathScaled);
            if (bSelected)
            {
                g.DrawRectangle(new Pen(Color.Red), _Bounds.X * w + x, _Bounds.Y * h + y, _Bounds.Width * w, _Bounds.Height * h);
            }
        }
    }
}
