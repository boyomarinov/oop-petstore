using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Products;

namespace PetStore.People
{
    interface ICustomer
    {
        void BuyProduct(PetProduct product, Store store);
        List<PetProduct> BrowseProducts(); // from category?
        void ComplimentSeller(Seller seller, Store store);
        void GiveBadReviewToSeller(Seller seller, Store store);
        void MakeVetAppointment(Vet vet, DateTime date, Store store);
    }
}
