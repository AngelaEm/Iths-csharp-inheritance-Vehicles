using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class Cars : Vehicles
    {
        public int Doors { get; set; }    
        public string Fuel { get; set; }

        public override void StartVehicle()
        {
            Console.WriteLine($"The {Color} {Make} {Model} from {Year} with a maxspeed of {GetMaxSpeed()} km/h with {Doors} doors is starting.\n");
        }
    }
}
