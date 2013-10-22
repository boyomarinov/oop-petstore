using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Animals
{
    public class InvalidGenderException<T> : ApplicationException
    {
        private T maleGender;
        private T femaleGender;

        public T MaleGender
        {
            get { return this.maleGender; }
            set { this.maleGender = value; }
        }
        public T FemaleGender
        {
            get { return this.femaleGender; }
            set { this.femaleGender = value; }
        }

        public InvalidGenderException() : base() { }

        public InvalidGenderException(string message) : base(message) { }

        public InvalidGenderException(string message, T maleGender, T femaleGender) : base(message) 
        {
            this.MaleGender = maleGender;
            this.FemaleGender = femaleGender;
        }

        public InvalidGenderException(string message, Exception innerException, T maleGender, T femaleGender)
            : base(message, innerException)
        {
            this.MaleGender = maleGender;
            this.FemaleGender = femaleGender;
        }
        
    }
}
