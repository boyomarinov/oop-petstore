using System;

namespace PetStore.Animals
{
    public class Fish : Animal
    {
        #region Fields
        //Defining fields
        private FishType type;
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
        public FishType Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
            }
        }
        #endregion

        #region Constructors
        public Fish(float age, string breed, string gender, decimal price)
            : base(age, breed, gender, price)
        {
        }
        public Fish(float age, string breed, string gender, decimal price, string countryOfOrigin)
            : base(age, breed, gender, price, countryOfOrigin)
        {
        }
        public Fish(float age, string breed, string gender, decimal price, string countryOfOrigin, string name)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
        }
        public Fish(float age, string breed, string gender, decimal price, string countryOfOrigin, string name, int type)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
            this.Type = (FishType)type;
        }
        #endregion

        //Override method ToString()
        public override string ToString()
        {
            return string.Format("(Age: {0}, Breed: {1}, Gender: {2}, Price: {3}leva, Country of origin: {4}, Name: {5}, Type: {6})", this.Age, this.Breed, this.Gender, this.Price, this.CountryOfOrigin, this.Name, this.Type);
        }
    }
}
