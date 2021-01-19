using System;

namespace Kostenberekening_3D_printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string titel = "Kostenberekening Print";
            Console.WriteLine(titel);
            for (var i = 1; i < titel.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.Write("Type filament: " + "\n");
            string type = Console.ReadLine();
            Console.Write("Hoeveel kost de rol filament: " + "\n");
            decimal kostPerRol = decimal.Parse(Console.ReadLine());
            Console.Write("Hoeveel meter zit er op een rol: " + "\n");
            int aantalMeter = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Filament filament = new Filament(type, kostPerRol, aantalMeter);
            Console.WriteLine($"Je filament kost {filament.KostPerMeter()} per meter");
            Console.WriteLine("Hoelang duurt de print (aantal minuten): ");
            decimal duurtijd = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Hoeveel meter neemt de print: ");
            int aantalMeterPrint = int.Parse(Console.ReadLine());
            Print print = new Print(type, kostPerRol, aantalMeter, aantalMeterPrint, duurtijd);
            Console.WriteLine($"Je print kost {print.BerekenKostprijs()}");
            Console.ReadLine();
        }
    }
}
