using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Homework_05
{
    class Wizard
    {
        public string name;

        public int powerLevel;

        private int age;

        private DateTime dateOfAdmission;

        private bool isGraduated;

        public Wizard (string name, int powerLevel, int age, DateTime dateOfAdmission, bool isGraduated)
        {
            this.name = name;
            this.powerLevel = powerLevel;
            this.age = age;
            this.dateOfAdmission = dateOfAdmission;
            this.isGraduated = isGraduated;
        }
    }
}
