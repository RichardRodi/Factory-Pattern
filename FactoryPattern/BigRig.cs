﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("\nThis Big Rig tows a lot of weight");
        }
    }
}
