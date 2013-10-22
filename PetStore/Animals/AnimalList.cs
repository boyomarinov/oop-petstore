using System;
using System.Collections.Generic;
using System.Linq;
using PetStore.Animals;

namespace PetStore.Animals
{
    public class AnimalList<T> where T : Animal
    {
        private List<T> dataBase = new List<T>();

        #region Properties
        public List<T> DataBase
        {
            get { return this.dataBase; }
            set { this.dataBase = value; }
        }
        #endregion

        #region Constructors
        public AnimalList()
        {
            
        }
        public AnimalList(List<T> dataBase)
        {
            this.DataBase = dataBase;
        }
        #endregion

        #region Methods
        //Adding element
        public void Add(T element)
        {
            this.DataBase.Add(element);
        }
        //Clearing the list
        public void Clear()
        {
            this.DataBase.Clear();
        }
        //Printing the list
        public void PrintDataBase<K>()
        {
            for (int i = 0; i < this.DataBase.Count; i++)
            {
                Console.WriteLine(this.DataBase[i].ToString());
                Console.WriteLine();
            }
        }
        //Sort animals by age
        public void SortAge() 
        {
            var ageSort =
                from animal in this.DataBase
                orderby animal.Age ascending
                select animal;
            foreach (var animal in ageSort)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        //Sort animals by breed
        public void SortBreed()
        {
            var breedSort =
                from animal in this.DataBase
                orderby animal.Breed ascending
                select animal;
            foreach (var animal in breedSort)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        //Sort animals by gender
        public void SortGender()
        {
            var genderSort =
                from animal in this.DataBase
                orderby animal.Breed ascending
                select animal;
            foreach (var animal in genderSort)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        //Select animals by breed
        public void SelectBreed(string breed)
        {
            var breedSelect =
                from animal in this.DataBase
                where animal.Breed.ToLower() == breed.ToLower()
                select animal;
            foreach (var animal in breedSelect)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        #endregion
    }
}
