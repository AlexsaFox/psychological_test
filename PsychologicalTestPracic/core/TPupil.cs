using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_2.core
{
    public class TPupil
    {
        public string name;
        public string surname;
        public int age;
        public int grade;

        public TPupil(string name, string surname, int age, int grade)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.grade = grade;
        }
    }
}
