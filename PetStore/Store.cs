using System;
using System.Collections.Generic;
using System.Linq;

using PetStore.Animals;
using PetStore.People;
using PetStore.Products;
using PetStore.LoadDataFromFile;
using System.IO;


namespace PetStore
{
    public class Store
    {
        private StoreManager storeManager;
        private List<Seller> shopAssistants;
        private List<Customer> customers;
        private List<Vet> vets;
        private List<Animal> pets;
        private List<PetProduct> petProducts;

        #region Constructors
        public Store()
        {
            this.StoreManager = new StoreManager();
            this.ShopAssistants = new List<Seller>();
            this.Customers = new List<Customer>();
            this.Vets = new List<Vet>();
            this.Pets = new List<Animal>();
            this.PetProducts = new List<PetProduct>();
        }

        public Store(Store store)
        {
            this.StoreManager = store.StoreManager;

            //Copy Shop Assistants
            this.ShopAssistants = new List<Seller>();
            for (int i = 0; i < store.shopAssistants.Count; i++)
            {
                this.AddShopAssistant(store.ShopAssistants[i]);
            }

            //Copy customers
            this.Customers = new List<Customer>();
            for (int i = 0; i < store.Customers.Count; i++)
            {
                this.AddCustomer(store.Customers[i]);
            }

            //Copy vets
            this.Vets = new List<Vet>();
            for (int i = 0; i < store.Vets.Count; i++)
            {
                this.AddVet(store.Vets[i]);
            }

            //Copy pets
            this.Pets = new List<Animal>();
            for (int i = 0; i < store.Pets.Count; i++)
            {
                this.AddPet(store.Pets[i]);
            }

            //Copy products
            this.PetProducts = new List<PetProduct>();
            for (int i = 0; i < store.PetProducts.Count; i++)
            {
                this.AddPetProduct(store.PetProducts[i]);
            }
        }

        public Store(StoreManager storeManager, List<Seller> shopAssistants, List<Customer> customers,
            List<Vet> vets, List<PetProduct> petProducts)
        {
            this.StoreManager = storeManager;
            this.ShopAssistants = shopAssistants;
            this.Customers = customers;
            this.Vets = vets;
            this.Pets = new List<Animal>();
            //this.Pets = pets;
            this.PetProducts = petProducts;
        }
        #endregion

        #region Properties
        public StoreManager StoreManager
        {
            get { return storeManager; }
            set { storeManager = value; }
        }

        public List<Seller> ShopAssistants
        {
            get { return shopAssistants; }
            set { shopAssistants = value; }
        }

        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        public List<Vet> Vets
        {
            get { return vets; }
            set { vets = value; }
        }

        public List<Animal> Pets
        {
            get { return pets; }
            set { pets = value; }
        }

        public List<PetProduct> PetProducts
        {
            get { return petProducts; }
            set { petProducts = value; }
        }
        #endregion

        #region Add/Remove
        public void AddShopAssistant(Seller seller)
        {
            this.ShopAssistants.Add(seller);
        }
        public void RemoveShopAssistant(Seller seller)
        {
            this.ShopAssistants.Remove(seller);
        }

        public void AddCustomer(Customer customer)
        {
            this.Customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            this.Customers.Remove(customer);
        }

        public void AddVet(Vet vet)
        {
            this.Vets.Add(vet);
        }
        public void RemoveVet(Vet vet)
        {
            this.Vets.Remove(vet);
        }

        public void AddPet(Animal pet)
        {
            this.Pets.Add(pet);
        }
        public void RemovePet(Animal pet)
        {
            this.Pets.Remove(pet);
        }

        public void AddPetProduct(PetProduct petProduct)
        {
            //Check if product already exist in our store products
            PetProduct prod = this.PetProducts.Find(
                delegate(PetProduct p)
                {
                    return p.Name == petProduct.Name;
                });

            //if is new, add it to list
            if (prod == null)
            {
                this.PetProducts.Add(petProduct);
            }
            //if exists, increase its inStock
            else
            {
                //TEST
                prod.InStock++;
            }

        }
        public void RemovePetProduct(PetProduct petProduct)
        {
            PetProduct prod = this.PetProducts.Find(
                delegate(PetProduct p)
                {
                    return p.Name == petProduct.Name;
                });

            if (prod == null)
            {
                throw new ArgumentNullException("The product does not exist");
            }
            else
            {
                prod.InStock--;
            }

            //if there are no products left
            if (prod.InStock == 0)
            {
                this.PetProducts.Remove(petProduct);
            }
        }
        #endregion

        #region READAnimal
        //Read one "dog" line from file
        public static Dog ReadDog(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            float age = float.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[5].Trim();
            string color = splitLine[6].Trim();
            int fur = int.Parse(splitLine[7].Trim());

            Dog toReturn = new Dog(age, breed, gender, price, countryOfOrigin, name, color, fur);
            return toReturn;
        }

        //Read one cat 
        public static Cat ReadCat(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            float age = float.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[5].Trim();
            string color = splitLine[6].Trim();
            int fur = int.Parse(splitLine[7].Trim());

            Cat toReturn = new Cat(age, breed, gender, price, countryOfOrigin, name, color, fur);
            return toReturn;
        }

        //Method to read fish
        public static Fish ReadFish(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            float age = float.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[5].Trim();
            int type = int.Parse(splitLine[6].Trim());

            Fish toReturn = new Fish(age, breed, gender, price, countryOfOrigin, name, type);
            return toReturn;
        }

        //Method to Read bird from file
        public static Bird ReadBird(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            float age = float.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[5].Trim();
            int speech = int.Parse(splitLine[6].Trim());
            bool speaking = (speech == 1) ? true : false;

            Bird toReturn = new Bird(age, breed, gender, price, countryOfOrigin, name, speaking);
            return toReturn;
        }

        //Method to read reptile from file
        public static Reptile ReadReptile(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            float age = float.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[5].Trim();
            int venomousInt = int.Parse(splitLine[6].Trim());
            bool venomous = (venomousInt == 1) ? true : false;
            int typeSkinInt = int.Parse(splitLine[7].Trim());

            Reptile toReturn = new Reptile(age, breed, gender, price, countryOfOrigin, name, venomous, typeSkinInt);
            return toReturn;
        }

        //Method to read rodent from file
        public static Rodent ReadRodent(string animal)
        {
            //Animal animal = new Animal()
            string[] splitLine = animal.Split(',');

            float age = float.Parse(splitLine[0].Trim());
            string breed = splitLine[1].Trim();
            string gender = splitLine[2].Trim();
            decimal price = decimal.Parse(splitLine[3].Trim());
            string countryOfOrigin = splitLine[4].Trim();
            string name = splitLine[5].Trim();
            int category = int.Parse(splitLine[6].Trim());

            Rodent toReturn = new Rodent(age, breed, gender, price, countryOfOrigin, name, category);
            return toReturn;
        }

        public static List<Dog> ReadAllDogs(string fileName)
        {
            List<Dog> dogs = new List<Dog>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = String.Empty;
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
                string line = String.Empty;
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
                string line = String.Empty;
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
                string line = string.Empty;
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
                string line = String.Empty;
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
                string line = String.Empty;
                while ((line = readFile.ReadLine()) != null)
                {
                    rodents.Add(ReadRodent(line));
                }
            }

            return rodents;
        }

        public static List<Animal> ReadAllAnimalDataFromFile()
        {
            List<Animal> result = new List<Animal>();

            result.AddRange(ReadAllDogs(@"..\..\..\PetStore\LoadDataFromFile\DogList.txt"));
            result.AddRange(ReadAllCats(@"..\..\..\PetStore\LoadDataFromFile\CatList.txt"));
            result.AddRange(ReadAllFish(@"..\..\..\PetStore\LoadDataFromFile\FishList.txt"));
            result.AddRange(ReadAllBird(@"..\..\..\PetStore\LoadDataFromFile\BirdList.txt"));
            result.AddRange(ReadAllReptiles(@"..\..\..\PetStore\LoadDataFromFile\ReptileList.txt"));
            result.AddRange(ReadAllRodents(@"..\..\..\PetStore\LoadDataFromFile\RodentList.txt"));

            return result;
        }
        #endregion

        #region READPeople
        //Method to read store manager
        //edited to read directly from file, as Store has only one store manager
        public static StoreManager ReadStoreManager(string path) //(string person)
        {
            string manager = String.Empty;
            using (StreamReader readFile = new StreamReader(path))
            {
                manager = readFile.ReadLine();
            }

            string[] splitLine = manager.Split(',');

            string name = splitLine[0].Trim();
            uint age = uint.Parse(splitLine[1].Trim());

            StoreManager toReturn = new StoreManager(name, age);
            return toReturn;
        }

        //Method to read seller
        public static Seller ReadSeller(string person)
        {
            string[] splitLine = person.Split(',');

            string name = splitLine[0].Trim();
            uint age = uint.Parse(splitLine[1].Trim());
            int position = int.Parse(splitLine[2].Trim());
            int workHours = int.Parse(splitLine[3].Trim());
            double salary = double.Parse(splitLine[4].Trim());
            int reputation = int.Parse(splitLine[5].Trim());

            Seller toReturn = new Seller(name, age, position, workHours, salary, reputation);
            return toReturn;
        }

        //Method to read vet
        public static Vet ReadVet(string person)
        {
            string[] splitLine = person.Split(',');

            string name = splitLine[0].Trim();
            uint age = uint.Parse(splitLine[1].Trim());
            int specialization = int.Parse(splitLine[2].Trim());
            string phone = splitLine[3].Trim();

            Vet toReturn = new Vet(name, age, specialization, phone);
            return toReturn;
        }

        //Method to read customer
        public static Customer ReadCustomer(string person)
        {
            string[] splitLine = person.Split(',');

            string name = splitLine[0].Trim();
            uint age = uint.Parse(splitLine[1].Trim());
            string phone = splitLine[2].Trim();

            Customer toReturn = new Customer(name, age, phone);
            return toReturn;
        }

        public static List<StoreManager> ReadAllStoreManagers(string fileName)
        {
            List<StoreManager> storeManagers = new List<StoreManager>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = String.Empty;
                while ((line = readFile.ReadLine()) != null)
                {
                    storeManagers.Add(ReadStoreManager(line));
                }
            }

            return storeManagers;
        }

        public static List<Seller> ReadAllSellers(string fileName)
        {
            List<Seller> seller = new List<Seller>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = String.Empty;
                while ((line = readFile.ReadLine()) != null)
                {
                    seller.Add(ReadSeller(line));
                }
            }

            return seller;
        }

        public static List<Vet> ReadAllVets(string fileName)
        {
            List<Vet> vet = new List<Vet>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = String.Empty;
                while ((line = readFile.ReadLine()) != null)
                {
                    vet.Add(ReadVet(line));
                }
            }

            return vet;
        }

        public static List<Customer> ReadAllCustomers(string fileName)
        {
            List<Customer> customer = new List<Customer>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = String.Empty;
                while ((line = readFile.ReadLine()) != null)
                {
                    customer.Add(ReadCustomer(line));
                }
            }

            return customer;
        }
        #endregion

        public void PopulateData()
        {
            //Init Store Manager
            this.StoreManager = ReadStoreManager(@"..\..\..\PetStore\LoadDataFromFile\StoreManager.txt");

            //Init Pets
            this.Pets = new List<Animal>();
            List<Animal> inputCollection = ReadAllAnimalDataFromFile();
            for (int i = 0; i < inputCollection.Count; i++)
            {
                this.AddPet(inputCollection[i]);
            }

            //Init Products
            this.PetProducts = new List<PetProduct>();
            List<PetProduct> inputProductCollection = FileDataExtractor.ReadAllProductDataFromFile();
            for (int i = 0; i < inputProductCollection.Count; i++)
            {
                this.AddPetProduct(inputProductCollection[i]);
            }

            //Init Customers
            this.Customers = new List<Customer>();
            List<Customer> inputCustomerCollection = ReadAllCustomers(@"..\..\..\PetStore\LoadDataFromFile\CustomerList.txt");
            for (int i = 0; i < inputCustomerCollection.Count; i++)
            {
                this.AddCustomer(inputCustomerCollection[i]);
            }

            //Init Vets
            this.Vets = new List<Vet>();
            List<Vet> inputVetCollection = ReadAllVets(@"..\..\..\PetStore\LoadDataFromFile\VetList.txt");
            for (int i = 0; i < inputVetCollection.Count; i++)
            {
                this.AddVet(inputVetCollection[i]);
            }

            //Init Sellers
            this.ShopAssistants = new List<Seller>();
            List<Seller> inputSellerCollection = ReadAllSellers(@"..\..\..\PetStore\LoadDataFromFile\SellerList.txt");
            for (int i = 0; i < inputSellerCollection.Count; i++)
            {
                this.AddShopAssistant(inputSellerCollection[i]);
            }

        }

        #region Sorting methods
        //Sort animals by age
        public List<Animal> SortAge(string type)
        {
            List<Animal> toBeSorted = new List<Animal>();
            switch (type)
            {
                case "all":
                    toBeSorted.AddRange(this.Pets);
                    break;
                case "cat":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Cat).ToList());
                    break;
                case "dog":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Dog).ToList());
                    break;
                case "fish":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Fish).ToList());
                    break;
                case "bird":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Bird).ToList());
                    break;
                case "reptile":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Reptile).ToList());
                    break;
                case "rodent":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Rodent).ToList());
                    break;
                default:
                    toBeSorted.AddRange(this.Pets);
                    break;
            }

            var ageSort =
                from animal in toBeSorted
                orderby animal.Age ascending
                select animal;

            return ageSort.ToList<Animal>();
            //foreach (var animal in ageSort)
            //{
            //    Console.WriteLine(animal.ToString());
            //}
        }

        //Sort animals by breed
        public List<Animal> SortBreed(string type)
        {
            List<Animal> toBeSorted = new List<Animal>();
            switch (type)
            {
                case "all":
                    toBeSorted.AddRange(this.Pets);
                    break;
                case "cat":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Cat).ToList());
                    break;
                case "dog":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Dog).ToList());
                    break;
                case "fish":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Fish).ToList());
                    break;
                case "bird":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Bird).ToList());
                    break;
                case "reptile":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Reptile).ToList());
                    break;
                case "rodent":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Rodent).ToList());
                    break;
                default:
                    toBeSorted.AddRange(this.Pets);
                    break;
            }

            var breedSort =
                from animal in toBeSorted
                orderby animal.Breed ascending
                select animal;
            //foreach (var animal in breedSort)
            //{
            //    Console.WriteLine(animal.ToString());
            //}
            return breedSort.ToList<Animal>();
        }

        //Sort animals by gender
        public List<Animal> SortGender(string type)
        {
            List<Animal> toBeSorted = new List<Animal>();
            switch (type)
            {
                case "all":
                    toBeSorted.AddRange(this.Pets);
                    break;
                case "cat":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Cat).ToList());
                    break;
                case "dog":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Dog).ToList());
                    break;
                case "fish":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Fish).ToList());
                    break;
                case "bird":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Bird).ToList());
                    break;
                case "reptile":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Reptile).ToList());
                    break;
                case "rodent":
                    toBeSorted.AddRange(this.Pets.Where(x => x is Rodent).ToList());
                    break;
                default:
                    toBeSorted.AddRange(this.Pets);
                    break;
            }

            var genderSort =
                from animal in toBeSorted
                orderby animal.Gender ascending
                select animal;
            //foreach (var animal in genderSort)
            //{
            //    Console.WriteLine(animal.ToString());
            //}
            return genderSort.ToList<Animal>();
        }

        //TODO: input for breed
        //Select animals by breed
        public List<Animal> SelectBreed(string breed)
        {
            var breedSelect =
                from animal in this.Pets
                where animal.Breed.ToLower() == breed.ToLower()
                select animal;
            //foreach (var animal in breedSelect)
            //{
            //    Console.WriteLine(animal.ToString());
            //}
            return breedSelect.ToList<Animal>();
        }
        #endregion
    }
}
