using System;

namespace PetStore.Animals
{
    public class Rodent : Animal
    {
        #region Fields
        //Defining fields
        private CategoryRodent category;
        #endregion

        #region Properties
        //Defining properties
        public override float Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Invalid age! Age should be > 0 and < 10.");
                }
                this.age = value;
            }
        }
        public CategoryRodent Category
        {
            get { return this.category; }
            set
            {
                this.category = value;
            }
        }
        #endregion

        #region Constructors
        public Rodent(float age, string breed, string gender, decimal price)
            : base(age, breed, gender, price)
        {
        }
        public Rodent(float age, string breed, string gender, decimal price, string countryOfOrigin)
            : base(age, breed, gender, price, countryOfOrigin)
        {
        }
        public Rodent(float age, string breed, string gender, decimal price, string countryOfOrigin, string name)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
        }
        public Rodent(float age, string breed, string gender, decimal price, string countryOfOrigin, string name, int category)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
            this.Category = (CategoryRodent)category;
        }
        #endregion

        //Override method ToString()
        public override string ToString()
        {
            return string.Format("(Age: {0}, Breed: {1}, Gender: {2}, Price: {3}leva, Country of origin: {4}, Name: {5}, Category: {6})", this.Age, this.Breed, this.Gender, this.Price, this.CountryOfOrigin, this.Name, this.Category);
        }
    }
}
