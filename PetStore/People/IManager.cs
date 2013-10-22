using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Products;

namespace PetStore.People
{
    interface IManager
    {
        void HireShopAssistant(string name, Store store);
        void FireShopAssistant(string name, Store store);
        void ChangeProductPrice(string productName, double price, Store store);
    }
}
