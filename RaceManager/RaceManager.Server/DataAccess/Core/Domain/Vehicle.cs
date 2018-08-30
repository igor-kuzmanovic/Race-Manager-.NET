﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceManager.Server.DataAccess.Core.Domain
{
    class Vehicle : Entity
    {
        public Vehicle() { }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Type { get; set; }

        public double EngineHorsepower { get; set; }

        public double EngineDisplacement { get; set; }

        public Driver Driver { get; set; }
    }
}