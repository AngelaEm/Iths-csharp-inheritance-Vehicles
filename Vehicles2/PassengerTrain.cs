using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class PassengerTrain : Trains
    {
        public bool IsHighSpeedTrain;

        public PassengerTrain(bool isHighSpeedTrain)
        {
            IsHighSpeedTrain = isHighSpeedTrain;
        }
    }
}
