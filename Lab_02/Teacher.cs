using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Teacher : Person
    {
        // Klasa Teacher z dziedziczenia Person
        public Teacher(string name, int age) : base(name, age)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
        }

        // Wypis nauczyciela 
        public override string ToString()
        {
            return $"Treacher: {name} ({age} y.o.)";
        }
    }
}
