using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Task
    {
        // Klasa określa wykonywanie

        private string name;
        private TaskStatus status;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public TaskStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        public Task(string name, TaskStatus status)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.status = status;
        }

        // Wypis pełnej apki 
        public override string ToString()
        {
            return $"{name} [{status}]";
        }

        #nullable enable
        public bool Equals(Task? obj)
        {
            return base.Equals(obj);
        }
    }
}
