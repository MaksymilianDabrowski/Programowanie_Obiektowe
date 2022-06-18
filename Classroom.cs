using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Classroom
    {
        //  Klasa 

        private string name;
        private Person[] persons;
        public string Name
        {
            get;
            set;
        }

        public Classroom(string name, Person[] persons)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.persons = persons ?? throw new ArgumentNullException(nameof(persons));
        }
        
        // Wypis wartości klasy
        public override string ToString()
        {
            string x = $"Classroom: {name} \n";
            foreach (Person human in persons)
            {
                x += "\n" + human.ToString() + "\n";
            }
            return x;
        }
    }
}

