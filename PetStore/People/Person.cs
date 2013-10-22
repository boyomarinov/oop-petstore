using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.People
{
    public abstract class Person
    {
        private string name;
        private uint age;

        public Person()
        {
            this.Name = String.Empty;
            this.Age = 0;
        }

        public Person(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
        }

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public uint Age
        {
            get { return age; }
            set { age = value; }
        }
        #endregion
    }
}
