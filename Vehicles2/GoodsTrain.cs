﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles2
{
    internal class GoodsTrain : Trains
    {
        public bool IsDagerousGoods;

        public GoodsTrain(bool isDagerousGoods)
        {
            IsDagerousGoods = isDagerousGoods;
        }
    }
}
