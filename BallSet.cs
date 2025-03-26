using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonMaxwellGameLevelCreator
{
    public enum BallSetType
    {
        Rnd
    }

    public class BallSet : ObjBase
    {
        BallSetType _eSetType;
        private int _iNumInSet = 0;
        public RectangleF _rectBounds;
        public double _fVelrange, _fRadius;
        public Vect2 _Gravity;
        public Color _Colour;
        private Vect2[] _Centres; 

        public BallSet(BallSetType eSetType, int iNumInSet, RectangleF rectBounds, double fVelrange, double fRadius, Vect2 Gravity, Color Colour)
        {
            _eSetType = eSetType;
            _rectBounds = rectBounds;
            _fVelrange = fVelrange;
            _fRadius = fRadius;
            _Gravity = Gravity;
            _Colour = Colour;
            SetupRandomBallSet(iNumInSet);
        }

        private bool SetupRandomBallSet(int iNumInSet)
        {
            double rBig = _fRadius * 1.1;
            double rBigY = _fRadius * 1.1 * Form1._rectBounds.Width / Form1._rectBounds.Height;
            double r2 = rBig * rBig;
            double totalAreaBall = (double)iNumInSet * Math.PI * r2;
            double areaRect = _rectBounds.Width * _rectBounds.Height * Form1._rectBounds.Height / Form1._rectBounds.Width;
            if (totalAreaBall * 1.2 > areaRect)
                return false;

            _iNumInSet = iNumInSet;
            _Centres = new Vect2[_iNumInSet];
            for (int i = 0; i < _iNumInSet; i++)
            {
                bool bKeepTrying = false;
                do
                {
                    _Centres[i] = Vect2.RandomPointWithinRect(_rectBounds, rBig, rBigY);
                    bKeepTrying = false;
                    for (int j = 0; j < i; j++)
                    {
                        if ((_Centres[i] - _Centres[j]).LenSq < r2)
                        {
                            bKeepTrying = true;
                            break;
                        }
                    }
                }
                while (bKeepTrying);
            }
            return true;
        }

        public int NumInSet
        {
            get { return _iNumInSet; }
            set
            {
                if (_iNumInSet != value)
                {
                    SetupRandomBallSet(value);
                }
            }
        }

        public override void Draw(Graphics g, bool bSelected)
        {
            float w = Form1._rectBounds.Width;
            float h = Form1._rectBounds.Height;
            float x = Form1._rectBounds.X;
            float y = Form1._rectBounds.Y;
            SolidBrush br = new SolidBrush(Color.FromArgb(64, Color.Cyan));
            g.FillRectangle(br, _rectBounds.X * w + x, _rectBounds.Y * h + y, _rectBounds.Width * w, _rectBounds.Height * h);
            SolidBrush brBalls = new SolidBrush(_Colour);
            float r = (float)_fRadius;
            float diameter = r * 2.0f;
            foreach (Vect2 centre in _Centres)
            {
                g.FillEllipse(brBalls, (float)centre.X * w + x - r * w, (float)centre.Y * h + y - r * w, diameter * w, diameter * w);
            }
            Pen pen = bSelected ? new Pen(Color.Cyan, 5.0f) : new Pen(Color.Cyan);
            if(bSelected)
            {
                g.DrawRectangle(pen, _rectBounds.X * w + x, _rectBounds.Y * h + y, _rectBounds.Width * w, _rectBounds.Height * h);
            }
        }
    }
}
