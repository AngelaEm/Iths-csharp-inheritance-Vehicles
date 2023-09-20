using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class SailBoats : Boats
    {
        public int NumberOfSails;

        public SailBoats(int numberOfSails)
        {
            NumberOfSails = numberOfSails;
        }
    }
}
