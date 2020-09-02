using System;
using System.Collections.Generic;
using System.Text;

namespace opa
{
    class Person
    {
        private string _name;  // the name field
        public string Name    // the Name property
        {
            get => _name;
            set => _name = value;
        }

        public Person(string namepass)
        {
            this.Name = namepass;
        }
    }
}
