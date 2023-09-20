using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class Trains : Vehicles
    {
        public int NumberOfCarriage { get; set; }

        public override void StartVehicle()
        {
            Console.WriteLine($"The {Color} {Make} {Model} from {Year} with a maxspeed of {GetMaxSpeed()} km/h with {NumberOfCarriage} carriages is starting.\n");
        }

    }
}
