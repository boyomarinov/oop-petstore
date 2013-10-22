using System;

namespace PetStore.Animals
{
    public class Cat : Animal
    {
        #region Fields
        //Defining fields
        private string color;
        private Fur fur;
        #endregion

        #region Properties
        //Defining properties
        public override float Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException("Invalid age! Age should be > 0 and < 50.");
                }
                this.age = value;
            }
        }
        public string Color
        {
            get { return this.color; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    value = "No information available!";
                }
                this.color = value;
            }
        }
        public Fur Fur
        {
            get { return this.fur; }
            set
            {
                this.fur = value;
            }
        }
        #endregion

        #region Constructors
        public Cat(float age, string breed, string gender, decimal price)
            : base(age, breed, gender, price)
        {
        }
        public Cat(float age, string breed, string gender, decimal price, string countryOfOrigin)
            : base(age, breed, gender, price, countryOfOrigin)
        {
        }
        public Cat(float age, string breed, string gender, decimal price, string countryOfOrigin, string name)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
        }
        public Cat(float age, string breed, string gender, decimal price, string countryOfOrigin, string name, string color)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
            this.Color = color;
        }
        public Cat(float age, string breed, string gender, decimal price, string countryOfOrigin, string name, string color, int fur)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
            this.Color = color;
            this.Fur = (Fur)fur;
        }
        #endregion

        //Override method ToString()
        public override string ToString()
        {
            return string.Format("(Age: {0}, Breed: {1}, Gender: {2}, Price: {3}leva, Country of origin: {4}, Name: {5}, Color: {6}, Fur: {7})", this.Age, this.Breed, this.Gender, this.Price, this.CountryOfOrigin, this.Name, this.Color, this.Fur);
        }
    }
}
