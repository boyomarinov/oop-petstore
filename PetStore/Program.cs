using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Animals;
using PetStore.People;
using PetStore.Products;

namespace PetStore
{
    class Program
    {
        static void Main()
        {
            //string answer = "new";
            //string name;
            //byte age;
            //string breed;
            //string gender;
            //string select = "boxer";
            //decimal price;
            //AnimalList<Dog> newDataBase = new AnimalList<Dog>();
            //Dog newDog;
            //while (answer == "new")
            //{
            //    Console.WriteLine("-----------\nEnter Dog\n-----------");
            //    Console.Write("Name = ");
            //    name = Console.ReadLine();
            //    Console.Write("Age = ");
            //    age = byte.Parse(Console.ReadLine());
            //    Console.Write("Breed = ");
            //    breed = Console.ReadLine();
            //    Console.Write("Gender = ");
            //    gender = Console.ReadLine();
            //    Console.Write("Price = ");
            //    price = decimal.Parse(Console.ReadLine());
            //    newDog = new Dog(age, breed, gender, price, name);
            //    newDataBase.Add(newDog);
            //    Console.WriteLine("Enter word 'new' for new Dog:");
            //    answer = Console.ReadLine().ToLower();
            //}
            //Console.WriteLine("\n---------------\nDogs:\n---------------");
            //newDataBase.PrintDataBase<Dog>();
            //Console.WriteLine("Sort by age:");
            //newDataBase.SortAge();
            //Console.WriteLine("Sort by breed:");
            //newDataBase.SortBreed();
            //Console.WriteLine("Sort by gender:");
            //newDataBase.SortGender();
            //Console.WriteLine("Select dogs by breed 'boxer':");
            //newDataBase.SelectBreed(select);



            ////----------INIT STORE-----------------------------------------
            //StoreManager manager = new StoreManager("Dimitar Dimitrov", 39);

            //List<Seller> shopAssistants = new List<Seller>();
            //shopAssistants.Add(new Seller("Ivan Ivanov", 25, 1, 6));
            //shopAssistants.Add(new Seller("Maria Petkova", 28, SellerPosition.SeniorShopAssitant, 7));

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer("Joro", 22, "088123456"));
            //customers.Add(new Customer("Petko", 31, "088987654"));

            //List<Vet> vets = new List<Vet>();
            //vets.Add(new Vet("D-r Borislavov", 38, 0, "02123456"));
            //vets.Add(new Vet("D-r Krasimirova", 34, 1, new PhoneNumber("02987654")));

            //List<Animal> pets = new List<Animal>();
            //pets.Add(new Dog(1, "Nemska ovcharka", "male", 650, "Misho"));
            //pets.Add(new Dog(2, "Buldog", "male", 300, "Roko"));

            //List<PetProduct> products = new List<PetProduct>();
            //products.Add(new PetProduct("Test1", 20));
            //products.Add(new PetProduct("Test2", 30));

            //Store ourPetStore = new Store(manager, shopAssistants, customers, vets, pets, products);


            ////TEST FIRING A SHOP ASSISTANT
            ////Print initial shop assistants
            //foreach (Seller seller in ourPetStore.ShopAssistants)
            //{
            //    Console.WriteLine(seller);
            //}
            //Console.WriteLine();

            //ourPetStore.StoreManager.FireShopAssistant("Ivan Ivanov", ourPetStore);
            ////Print shop assistant after firing one
            //foreach (Seller seller in ourPetStore.ShopAssistants)
            //{
            //    Console.WriteLine(seller);
            //}
            //Console.WriteLine();

            ////TEST CHANGING PRICE OF PRODUCT
            //ourPetStore.StoreManager.ChangeProductPrice("Test1", 100, ourPetStore);
            //foreach (PetProduct item in ourPetStore.PetProducts)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //List<PetProduct> list = FileDataExtractor.ReadAllDataFromFile();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
