using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PetStore.Animals;

namespace PetStore.LoadDataFromFile
{
    public class LoadData
    {
        #region READ
        //Read one "dog" line from file
        public static Dog ReadDog(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            byte age = byte.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[6].Trim();
            string color = splitLine[7].Trim();
            int fur = int.Parse(splitLine[8].Trim());

            Dog toReturn = new Dog(age, breed, gender, price, countryOfOrigin, name, color, fur);
            return toReturn;
        }

        //Read one cat 
        public static Cat ReadCat(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            byte age = byte.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[6].Trim();
            string color = splitLine[7].Trim();
            int fur = int.Parse(splitLine[8].Trim());

            Cat toReturn = new Cat(age, breed, gender, price, countryOfOrigin, name, color, fur);
            return toReturn;
        }

        //Method to read fish
        public static Fish ReadFish(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            byte age = byte.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[6].Trim();
            int type = int.Parse(splitLine[7].Trim());

            Fish toReturn = new Fish(age, breed, gender, price, countryOfOrigin, name, type);
            return toReturn;
        }

        //Method to Read bird from file
        public static Bird ReadBird(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            byte age = byte.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[6].Trim();
            int speech = int.Parse(splitLine[7].Trim());
            bool speaking = (speech == 1) ? true : false;

            Bird toReturn = new Bird(age, breed, gender, price, countryOfOrigin, name, speaking);
            return toReturn;
        }

        //Method to read reptile from file
        public static Reptile ReadReptile(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            byte age = byte.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[6].Trim();
            int venomousInt = int.Parse(splitLine[7].Trim());
            bool venomous = (venomousInt == 1) ? true : false;
            int typeSkinInt = int.Parse(splitLine[8].Trim());

            Reptile toReturn = new Reptile(age, breed, gender, price, countryOfOrigin, name, venomous, typeSkinInt);
            return toReturn;
        }

        //Method to read rodent from file
        public static Rodent ReadRodent(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            byte age = byte.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[6].Trim();
            int category = int.Parse(splitLine[7].Trim());

            Rodent toReturn = new Rodent(age, breed, gender, price, countryOfOrigin, name, category);
            return toReturn;
        }

        public static List<Dog> ReadAllDogs(string fileName)
        {
            List<Dog> dogs = new List<Dog>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                while ((line = readFile.ReadLine()) != null)
                {
                    dogs.Add(ReadDog(line));
                }
                #region old
                //string[] splitLine;
                //byte age;
                //string breed;
                //string gender;
                //decimal price;
                //string countryOfOrigin;
                //string information;
                //string name;
                //T newAnimal;
                //while (line != null)
                //{
                //    splitLine = line.Split(',');
                //    age = byte.Parse(splitLine[0].Trim());
                //    breed = splitLine[1].Trim();
                //    gender = splitLine[2].Trim();
                //    price = decimal.Parse(splitLine[3].Trim());
                //    countryOfOrigin = splitLine[4].Trim();
                //    information = splitLine[5].Trim();
                //    name = splitLine[6].Trim();
                //    newAnimal = new T(age, breed, gender, price, countryOfOrigin, information, name);
                //    newDataBase.Add(newAnimal);
                //    line = readFile.ReadLine();
                //}
                #endregion
            }

            return dogs;
        }

        public static List<Cat> ReadAllCats(string fileName)
        {
            List<Cat> cats = new List<Cat>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                while ((line = readFile.ReadLine()) != null)
                {
                    cats.Add(ReadCat(line));
                }
            }

            return cats;
        }

        public static List<Fish> ReadAllFish(string fileName)
        {
            List<Fish> fish = new List<Fish>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                while ((line = readFile.ReadLine()) != null)
                {
                    fish.Add(ReadFish(line));
                }
            }

            return fish;
        }

        public static List<Bird> ReadAllBird(string fileName)
        {
            List<Bird> birds = new List<Bird>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                while ((line = readFile.ReadLine()) != null)
                {
                    birds.Add(ReadBird(line));
                }
            }

            return birds;
        }

        public static List<Reptile> ReadAllReptiles(string fileName)
        {
            List<Reptile> reptiles = new List<Reptile>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                while ((line = readFile.ReadLine()) != null)
                {
                    reptiles.Add(ReadReptile(line));
                }
            }

            return reptiles;
        }

        public static List<Rodent> ReadAllRodents(string fileName)
        {
            List<Rodent> rodents = new List<Rodent>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                while ((line = readFile.ReadLine()) != null)
                {
                    rodents.Add(ReadRodent(line));
                }
            }

            return rodents;
        }

        public static List<Animal> ReadAllDataFromFile()
        {
            List<Animal> result = new List<Animal>();

            result.AddRange(ReadAllDogs(@"DogList.txt"));
            result.AddRange(ReadAllCats(@"CatList.txt"));
            result.AddRange(ReadAllFish(@"FishList.txt"));
            result.AddRange(ReadAllBird(@"BirdList.txt"));
            result.AddRange(ReadAllReptiles(@"ReptileList.txt"));
            result.AddRange(ReadAllRodents(@"RodentList.txt"));

            return result;
        }
        #endregion

    }
}
