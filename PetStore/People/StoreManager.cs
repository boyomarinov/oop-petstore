using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Products;

namespace PetStore.People
{
    public class StoreManager : Person, IManager
    {
        public StoreManager()
            :base()
        { }

        public StoreManager(string name, uint age)
            : base(name, age)
        { }

        public override string ToString()
        {
            return String.Format("Manager\n{0}, {1}", this.Name, this.Age);
        }

        //Method to implement hiring shop assistant functionality
        public void HireShopAssistant(string name, Store store)
        {
            Console.WriteLine("{0} was hired :)", name);
            var result =
                from s in store.ShopAssistants
                where s.Name == name
                select s;
            Seller toBeHired = result.ToList<Seller>()[0];
            store.RemoveShopAssistant(toBeHired);
        }

        //Method to implement firing shop assistant functionality
        public void FireShopAssistant(string name, Store store)
        {
            Console.WriteLine("{0} was fired :(", name);
            var result =
                from s in store.ShopAssistants
                where s.Name == name
                select s;
            Seller toBeFired = result.ToList<Seller>()[0];
            store.RemoveShopAssistant(toBeFired);
        }

        
        //Update all products in store with the new price
        public void ChangeProductPrice(string productName, double price, Store store)
        {
            store.PetProducts.FindAll(
                delegate(PetProduct p)
                {
                    return p.Name == productName;
                }
            ).ToList<PetProduct>().ForEach(x => x.Price = price);
        }
    }
}
