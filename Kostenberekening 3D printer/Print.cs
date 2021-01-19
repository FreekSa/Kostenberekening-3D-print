using System;
using System.Collections.Generic;
using System.Text;

namespace Kostenberekening_3D_printer
{
    public class Print : Filament,IKost
    {
        decimal Duurtijd { get; set; }
        int AantalMeterPrint { get; set; }

        public Print(string type, decimal kostPerRol, int aantalMeter, int aantalMeterPrint, decimal duurtijd) : base(type, kostPerRol, aantalMeter)
        {
            Duurtijd = duurtijd;
            AantalMeterPrint = aantalMeterPrint;
        }

        public virtual decimal BerekenKostprijs()
        {
            return KostPerMeter() * AantalMeterPrint * Duurtijd / 100;
        }
    }
}
