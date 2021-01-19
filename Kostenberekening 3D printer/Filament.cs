﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kostenberekening_3D_printer
{
    public class Filament
    {
        string Type { get; set; }
        decimal KostPerRol { get; set; }
        int AantalMeter { get; set; }
        public decimal KostprijsPrint { get; set; }

        public Filament(string type, decimal kostPerRol, int aantalMeter)
        {
            Type = type;
            KostPerRol = kostPerRol;
            AantalMeter = aantalMeter;
        }

        public decimal KostPerMeter()
        {
            decimal kostPermeter = KostPerRol / AantalMeter;
            return kostPermeter;
        }
    }
}