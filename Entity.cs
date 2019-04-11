using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Entity
    {
        private int x;
        private int y;
        private string name;
        public static int numEntities = 0;

        protected int X { get => x; set => x = value; }
        protected int Y { get => y; set => y = value; }
        public string Name { get => name; protected set => name = value; }

        public Entity(string name)
        {
            Name = name;
            numEntities++;
        }

        public Entity()
        {
            Name = "Default Entity";
            numEntities++;
        }

        public virtual void Report()
        {
            Console.WriteLine($"{Name} is at X:{X} Y:{Y}");
        }
    }
}
    

