using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Products;

namespace PetStore.People
{
    interface ISeller
    {
        void SellProduct(PetProduct product, Store store);
        void SuggestProduct(Store store);
        //void OpenShop();
        //void CloseShop();
    }
}
