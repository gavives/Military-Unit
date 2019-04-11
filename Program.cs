using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Domain;

namespace Military_Unit
{
    class Program
    {
        static void Main(string[] args)
        {

            Hmmwv vee = new Hmmwv("Humvee 1");
            Hmmwv medichmmwv = new Hmmwv("Medical Humvee");
            Helicopter heli = new Helicopter("Apache");
            Helicopter heli2 = new Helicopter("Chinhook");
            Helicopter heli3 = new Helicopter("Black Hawk");
            Medic medic = new Medic("SF Tom");
            Infrantry inf1 = new Infrantry("Brian");
            Infrantry inf2 = new Infrantry("Steve");

            Console.WriteLine("Report total number of vehicles");
            Console.WriteLine(Vehicle.numVehicles);
            Console.WriteLine("Report total number of helicopters");
            Console.WriteLine(Helicopter.numHelicopters);
            Console.WriteLine("Report total number of Hmmwvs");
            Console.WriteLine(Hmmwv.numHmmwv);
            Console.WriteLine("Report total number of Personnel");
            Console.WriteLine(Personnel.numPersonnel);

            Console.WriteLine("\nHumvee 1 move");
            vee.MoveTo(3, 3);
            vee.Stop();

            Console.WriteLine("\nApache move");
            heli.MoveTo(2, 2);
            heli.Stop();

            Console.WriteLine("\nMedic move");
            medic.MoveTo(3, 3);
            medic.Stop();

            Console.WriteLine("\nBrian Move");
            inf1.MoveTo(4, 4);
            inf1.Stop();
        }
    }
}
        
    

