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
    public static class DrawFuncs
    {
        public static Vect2[] _trigtable = new Vect2[360];

        public static void Initialize()
        {
            for (int i = 0; i < 360; i++)
            {
                double a = (double)i * Math.PI * 2.0 / (double)360;
                _trigtable[i].X = Math.Cos(a);
                _trigtable[i].Y = Math.Sin(a);
            }
        }
    }
}
