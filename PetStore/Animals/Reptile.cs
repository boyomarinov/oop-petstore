using System;

namespace PetStore.Animals
{
    public class Reptile : Animal
    {
        #region Fields
        //Defining fields
        private bool venomous;
        private TypeSkin typeSkin;
        #endregion

        #region Properties
        //Defining properties

        public override float Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException("Invalid age! Age should be > 0 and < 60.");
                }
                this.age = value;
            }
        }
        public bool Venomous
        {
            get { return this.venomous; }
            set
            {
                this.venomous = value;
            }
        }
        public TypeSkin TypeSkin
        {
            get { return this.typeSkin; }
            set
            {
                this.typeSkin = value;
            }
        }
        #endregion

        #region Constructors
        public Reptile(float age, string breed, string gender, decimal price)
            : base(age, breed, gender, price)
        {
        }
        public Reptile(float age, string breed, string gender, decimal price, string countryOfOrigin)
            : base(age, breed, gender, price, countryOfOrigin)
        {
        }
        public Reptile(float age, string breed, string gender, decimal price, string countryOfOrigin, string name)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
        }
        public Reptile(float age, string breed, string gender, decimal price, string countryOfOrigin, string name, bool venomous)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
            this.Venomous = venomous;
        }
        public Reptile(float age, string breed, string gender, decimal price, string countryOfOrigin, string name, bool venomous, int typeSkin)
            : base(age, breed, gender, price, countryOfOrigin, name)
        {
            this.Venomous = venomous;
            this.TypeSkin = (TypeSkin)typeSkin;
        }
        #endregion

        //Override method ToString()
        public override string ToString()
        {
            return string.Format("(Age: {0}, Breed: {1}, Gender: {2}, Price: {3}leva, Country of origin: {4}, Name: {5}, Venomous: {6}, Type Skin: {7})", this.Age, this.Breed, this.Gender, this.Price, this.CountryOfOrigin, this.Name, this.Venomous, this.TypeSkin);
        }
    }
}
