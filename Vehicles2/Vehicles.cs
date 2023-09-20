using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class Vehicles
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; private set; }

        public virtual void StartVehicle()
        {
            Console.WriteLine($"The {Color} {Make} {Model} from {Year} with a maxspeed of {MaxSpeed} km/h is starting.\n");
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            

        }


        public int GetMaxSpeed()
        {
            return MaxSpeed;
        }
    }


}
