using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    public class Personnel : Entity, IMove
    {
        public static int numPersonnel = 0;

        public Personnel()
        {
            Name = "John Doe";
            numPersonnel++;
        }

        public Personnel(string name) : base(name)
        {
            numPersonnel++;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoveTo(int x, int y)
        {
            Speak();
            Move(x, y);
            Report();
        }

        protected virtual void Speak()
        {
            Console.WriteLine("Roger that. ");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} stops moving and parade rest.");
        }
    }
}

