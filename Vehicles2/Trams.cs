using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class Trams : Trains
    {
        public string Power;

        public Trams(string power)
        {
            Power = power;
        }
    }
}
