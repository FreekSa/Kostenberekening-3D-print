using System;
using System.Collections.Generic;
using System.Text;

namespace Kostenberekening_3D_printer
{
    public class Print : Filament,IKost
    {
        decimal Duurtijd { get; set; }
        int AantalMeterPrint { get; set; }

        public Print(string type, decimal kostPerRol, int aantalMeterPrint, decimal duurtijd) : base(type, kostPerRol)
        {
            Duurtijd = duurtijd;
            AantalMeterPrint = aantalMeterPrint;
        }

        public virtual decimal BerekenKostprijs()
        {
            return KostPerMeter() * AantalMeterPrint + 0.0534m * Duurtijd;
        }
    }
}
