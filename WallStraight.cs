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
    public class WallStraight : WallBase
    {
        public Vect2 _Start, _End, _Unit;//, _StartInfinite, _EndInfinite; TODO
        public double _Left, _Top, _Right, _Bottom, _Length;

        public WallStraight(Vect2 start, Vect2 end, bool removable) : base()
        {
            _Start = start;
            _End = end;
            _Left = Math.Min(_Start.X, _End.X);
            _Top = Math.Min(_Start.Y, _End.Y);
            _Right = Math.Max(_Start.X, _End.X);
            _Bottom = Math.Max(_Start.Y, _End.Y);
            Vect2 startToEnd = _End - _Start;
            _Length = startToEnd.Len;
            _Unit = startToEnd / _Length;
            _bRemovable = removable;
        }

        public Vect2 Start => _Start;
        public Vect2 End => _End;
        public Vect2 UnitVect => _Unit;
        public double Length => _Length;
        public double Left => _Left;
        public double Top => _Top;
        public double Right => _Right;
        public double Bottom => _Bottom;

        public override void Draw(Graphics g, bool bSelected)
        {
            float w = Form1._rectBounds.Width;
            float h = Form1._rectBounds.Height;
            float x = Form1._rectBounds.X;
            float y = Form1._rectBounds.Y;
            Pen pen = bSelected ? new Pen(DrawColour, 5.0f) : new Pen(DrawColour);
            g.DrawLine(pen, (float)_Start.X * w + x, (float)_Start.Y * h + y, (float)_End.X * w + x, (float)_End.Y * h + y);
        }
    }
}
