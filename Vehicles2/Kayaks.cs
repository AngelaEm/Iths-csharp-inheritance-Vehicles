using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class Kayaks : Boats
    {
        public bool IsSitOnTop;

        public Kayaks(bool isSitOnTop)
        {
            IsSitOnTop = isSitOnTop;
        }
    }
}
