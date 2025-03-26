using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonMaxwellGameLevelCreator
{
    abstract public class ObjBase
    {
        public ObjBase()
        {
        }

        public abstract void Draw(Graphics g, bool bSelected);
    }
}
