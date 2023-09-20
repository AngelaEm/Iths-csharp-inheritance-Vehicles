using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class MotorBoats : Boats
    {
        public int EnginePower;

        public MotorBoats(int enginePower)
        {
            EnginePower = enginePower;
        }
    }
}
