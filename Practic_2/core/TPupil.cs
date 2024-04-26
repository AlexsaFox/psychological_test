using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    internal class TPupil
    {
        public required string name;
        public required string surname;
        public required int age;
        public required int grade;

        public TPupil(string name, string surname, int age, int grade)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.grade = grade;
        }
    }
}
