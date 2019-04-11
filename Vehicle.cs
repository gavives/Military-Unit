using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    public class Vehicle : Entity, IMove, ISound
    {
        public static int numVehicles = 0;

        protected string sound = "Vroom vroom vroom";

        public string Sound { get => sound; set => sound = value; }

        public Vehicle() : base()
        {
            Name = "Default Vehicle";
            numVehicles++;
        }

        public Vehicle(string name) : base(name)
        {
            numVehicles++;
        }

        protected virtual void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void MoveTo(int x, int y)
        {
            StartEngine();
            MakeSound();
            Move(x, y);
            Report();
        }

        public virtual void Stop()
        {
            MakeSound();
            StopEngine();
        }

        public virtual void StartEngine()
        {
            Console.WriteLine($"{Name} Starting Engine...");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Default Drive");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine($"{Name} Stopping Engine...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(Sound);
        }

    }
}

