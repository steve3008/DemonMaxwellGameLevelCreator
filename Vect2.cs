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
    public struct Vect2
    {
        public static readonly Random _Rnd = new Random();
        public double X, Y;

        public Vect2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double LenSq
        {
            get { return X * X + Y * Y; }
        }

        public double Len
        {
            get { return Math.Sqrt(LenSq); }
        }

        public Vect2 Unit
        {
            get
            {
                return this / Len;
            }
        }

        public double Dot(Vect2 v)
        {
            return X * v.X + Y * v.Y;
        }

        public Vect2 RotatedLeft90
        {
            get { return new Vect2(Y, -X); }
        }

        public Vect2 RotatedRight90
        {
            get { return new Vect2(-Y, X); }
        }

        public static Vect2 RandomPointWithinRect(RectangleF rect)
        {
            return new Vect2(_Rnd.NextDouble() * rect.Width + rect.Left,
                             _Rnd.NextDouble() * rect.Height + rect.Top);
        }
        public static Vect2 RandomPointWithinRect(RectangleF rect, double border)
        {
            double b2 = border * 2.0;
            return new Vect2(_Rnd.NextDouble() * (rect.Width - b2) + rect.Left + border,
                             _Rnd.NextDouble() * (rect.Height - b2) + rect.Top + border);
        }

        public static Vect2 RandomPointWithinRect(RectangleF rect, double borderX, double borderY)
        {
            double bX2 = borderX * 2.0;
            double bY2 = borderY * 2.0;
            return new Vect2(_Rnd.NextDouble() * (rect.Width - bX2) + rect.Left + borderX,
                             _Rnd.NextDouble() * (rect.Height - bY2) + rect.Top + borderY);
        }

        public static Vect2 RandomPointWithinSquare(double side)
        {
            double s2 = side * 0.5;
            return new Vect2(_Rnd.NextDouble() * side - s2,
                             _Rnd.NextDouble() * side - s2);
        }

        public static implicit operator PointF(Vect2 v)
        {
            return new PointF((float)v.X, (float)v.Y);
        }

        public static implicit operator Vect2(PointF p)
        {
            return new Vect2(p.X, p.Y);
        }
        public static implicit operator Point(Vect2 v)
        {
            return new Point((int)v.X, (int)v.Y);
        }

        public static implicit operator Vect2(Point p)
        {
            return new Vect2(p.X, p.Y);
        }

        public static Vect2 operator +(Vect2 v1, Vect2 v2)
        {
            return new Vect2(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vect2 operator -(Vect2 v1, Vect2 v2)
        {
            return new Vect2(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vect2 operator -(Vect2 v)
        {
            return new Vect2(-v.X, -v.Y);
        }

        public static Vect2 operator *(Vect2 v, double n)
        {
            return new Vect2(v.X * n, v.Y * n);
        }

        public static Vect2 operator *(double n, Vect2 v)
        {
            return new Vect2(v.X * n, v.Y * n);
        }

        public static Vect2 operator /(Vect2 v, double n)
        {
            return new Vect2(v.X / n, v.Y / n);
        }
    }
}
