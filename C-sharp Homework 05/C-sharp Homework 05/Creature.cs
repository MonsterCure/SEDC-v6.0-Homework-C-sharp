using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Homework_05
{
    class Creature
    {
        public string name;

        public int powerLevel;

        private int age;

        public bool isTamed;

        public Creature(string name, int powerLevel, int age, bool isTamed)
        {
            this.name = name;
            this.powerLevel = powerLevel;
            this.age = age;
            this.isTamed = isTamed;
        }
    }
}
