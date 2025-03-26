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
    abstract public class WallBase : ObjBase
    {
        protected static Color _Colour = Color.Red;
        public bool _bFiniteStart = true, _bFiniteEnd = true;
        public bool _bBounceOffCorners = true;
        public bool _bRemovable = false;
        protected bool _bVisible = true;

        public WallBase() : base()
        {
            _bFiniteStart = true;
            _bFiniteEnd = true;
            _bBounceOffCorners = true;
        }

        public bool IsVisible => _bVisible;

        protected Color DrawColour
        {
            get
            {
                return _bVisible ? (_bRemovable ? Color.Blue : _Colour) : Color.Black;
            }
        }
    }
}
