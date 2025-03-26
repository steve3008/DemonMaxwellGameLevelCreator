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
    public class WallArc : WallBase
    {
        public Vect2 _Centre;
        public double _fRadius;
        public int _iStartAngle;
        public int _iEndAngle;

        private RectangleF _Bounds;
        private PointF[] _Path = null;

        public WallArc(Vect2 centre, double radius, int startAngle, int endAngle, bool removable) : base()
        {
            _Centre = centre;
            _fRadius = radius;
            _iStartAngle = startAngle;
            _iEndAngle = endAngle;
            _bRemovable = removable;
        }

        public void SetPoints()
        {
            int end = (_iEndAngle > _iStartAngle) ? _iEndAngle : (_iEndAngle + 360);
            double left = 10000.0, top = 10000.0, right = -10000.0, bottom = -10000.0;
            double fCircum = 2.0 * Math.PI * _fRadius * (double)(end - _iStartAngle) / 360.0;
            int iLastPnt = Math.Min(Math.Max((int)(fCircum * 20.0), 2), 89);
            _Path = new PointF[iLastPnt + 1];
            double adjust = (double)Form1._rectBounds.Width / (double)Form1._rectBounds.Height;
            for (int i = 0; i <= iLastPnt; i++)
            {
                int ang = (_iStartAngle + i * (end - _iStartAngle) / iLastPnt) % 360;
                Vect2 pnt = DrawFuncs._trigtable[ang] * _fRadius;
                pnt.Y *= adjust;
                pnt += _Centre;
                _Path[i] = pnt;
                if (left > pnt.X)
                    left = pnt.X;
                if (top > pnt.Y)
                    top = pnt.Y;
                if (right < pnt.X)
                    right = pnt.X;
                if (bottom < pnt.Y)
                    bottom = pnt.Y;
            }
            _Bounds = new RectangleF((float)left, (float)top, (float)(right - left), (float)(bottom - top));
        }

        public PointF StartPoint
        {
            get
            {
                return _Path == null? new PointF(0, 0) : _Path.First();
            }
        }

        public PointF EndPoint
        {
            get
            {
                return _Path == null ? new PointF(0, 0) : _Path.Last();
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
            if(bSelected)
            {
                g.DrawRectangle(new Pen(Color.Red), _Bounds.X * w + x, _Bounds.Y * h + y, _Bounds.Width * w, _Bounds.Height * h);
            }
        }
    }
}
