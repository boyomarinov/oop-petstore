using System;

namespace PetStore.Animals
{
    public abstract class Animal
    {
        #region Fields
        //Defining fields
        private string name;
        protected float age;
        private string breed;
        private string gender;
        private decimal price;
        private string countryOfOrigin;
        private uint availableQuantity;
        static InvalidGenderException<string> genderException = new InvalidGenderException<string>("Invalid gender! Gender should be '{0}' or '{1}'", "male", "female");
        #endregion

        #region Properties
        //Defining properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    value = "No name!";
                }
                this.name = value;
            }
        }

        public abstract float Age
        {
            get;
            set;
        }
        public string Breed
        {
            get { return this.breed; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Breed cannot be empty!");
        }
                this.breed = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Gender cannot be empty!");
                }
                if (value.ToLower() != genderException.FemaleGender && value.ToLower() != genderException.MaleGender)
                {
                    throw genderException;
                }
                this.gender = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
        {
                    throw new ArgumentException("Invalid price! It should be > 0.");
                }
                this.price = value;
            }
        }
        public string CountryOfOrigin
        {
            get { return this.countryOfOrigin; }
            set
            {
                if (String.IsNullOrEmpty(value))
        {
                    value = "No information available!";
                }
                this.countryOfOrigin = value;
            }
        }
        public uint AvailableQuantity
        {
            get { return this.availableQuantity; }
            set { this.availableQuantity = value; }
        }
        #endregion

        #region Constructors
        public Animal(float age, string breed, string gender, decimal price)
            : this(age, breed, gender, price, null, null)
        {
            this.Age = age;
            this.Breed = breed;
            this.Gender = gender;
            this.Price = price;
        }
        public Animal(float age, string breed, string gender, decimal price, string countryOfOrigin)
            : this(age, breed, gender, price, countryOfOrigin, null)
        {
            this.Age = age;
            this.Breed = breed;
            this.Gender = gender;
            this.Price = price;
            this.CountryOfOrigin = countryOfOrigin;
        }
        public Animal(float age, string breed, string gender, decimal price, string countryOfOrigin, string name)
        {
            this.Age = age;
            this.Breed = breed;
            this.Gender = gender;
            this.Price = price;
            this.CountryOfOrigin = countryOfOrigin;
            this.Name = name;
        }

        public virtual void WriteToFile(string path)
        {

        }
        #endregion

    }
}
