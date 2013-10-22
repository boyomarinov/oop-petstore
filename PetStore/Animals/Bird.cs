using System;

namespace PetStore.Animals
{
    public class Bird : Animal
    {
        #region Fields
        //Defining fields
        private bool speaking;
        #endregion

        #region Properties
        //Defining properties
        
        public override float Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid age! Age should be > 0 and < 100.");
                }
                this.age = value;
            }
        }
        public bool Speaking
        {
            get { return this.speaking; }
            set { this.speaking = value; }
        }
        #endregion

        #region Constructors
        public Bird(float age, string breed, string gender, decimal price)
            : base(age, breed, gender, price)
        {
        }
        public Bird(float age, string breed, string gender, decimal price, string countryOfOrigin)
            : base(age, breed, gender, price, countryOfOrigin)
        {
        }
        public Bird(float age, string breed, string gender, decimal price, string countryOfOrigin, string name)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
        }
        public Bird(float age, string breed, string gender, decimal price, string countryOfOrigin, string name, bool speaking)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
            this.Speaking = speaking;
        }
        #endregion

        //Override method ToString()
        public override string ToString()
        {
            return string.Format("(Age: {0}, Breed: {1}, Gender: {2}, Price: {3}leva, Country of origin: {4}, Name: {5}, Speaking: {6})", this.Age, this.Breed, this.Gender, this.Price, this.CountryOfOrigin, this.Name, this.Speaking);
        }

        public override void WriteToFile(string path)
        {
            
        }
    }
}
