﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transportation_System.Core.Domain
{
    public enum VehicleType
    {
        TokTok
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleName { get; set; }
    }
}
