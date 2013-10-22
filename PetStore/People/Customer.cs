using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Animals;
using PetStore.Products;

namespace PetStore.People
{
    public class Customer : Person, ICustomer
    {
        private string phoneNumber;
        private List<Animal> customerPets;
        private List<PetProduct> purchasedProducts;
        
        #region Constructors
        public Customer()
            :base()
        {
            this.phoneNumber = String.Empty;
            this.CustomerPets = new List<Animal>();
            this.PurchasedProducts = new List<PetProduct>();
        }

        public Customer(string name, uint age, string phoneNumber)
            : base(name, age)
        {
            this.CustomerPets = new List<Animal>();
            this.PhoneNumber = phoneNumber;
            this.PurchasedProducts = new List<PetProduct>();
        }

        public Customer(string name, uint age, string phoneNumber, List<Animal> customerPets)
            : this(name, age, phoneNumber)
        {
            this.CustomerPets = customerPets;
            this.PurchasedProducts = new List<PetProduct>();
        }

        public Customer(string name, uint age, string phoneNumber, List<Animal> customerPets, List<PetProduct> purchasedProducts)
            : this(name, age, phoneNumber, customerPets)
        {
            this.PurchasedProducts = purchasedProducts;
        }
        #endregion

        #region Properties
        public List<Animal> CustomerPets
        {
            get { return customerPets; }
            set { customerPets = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public List<PetProduct> PurchasedProducts
        {
            get { return purchasedProducts; }
            set { purchasedProducts = value; }
        }

        #endregion

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", this.Name, this.Age, this.PhoneNumber);
        }

        public void BuyNewPet(Animal pet, Store store)
        {
            this.CustomerPets.Add(pet);
            store.RemovePet(pet);
        }

        public void BuyProduct(PetProduct product, Store store)
        {
            store.RemovePetProduct(product);
            this.PurchasedProducts.Add(product);
        }

        public void ReturnPurchasedProduct(PetProduct product, Store store)
        {
            store.AddPetProduct(product);
            this.PurchasedProducts.Remove(product);
        }

        public List<PetProduct> BrowseProducts()
        {
            List<PetProduct> list = new List<PetProduct>();
            //TODO: return list of products from given category
            return list;
        }

        public void ComplimentSeller(Seller seller, Store store)
        {
            //increase reputation of seller
            store.ShopAssistants
                .Where(x => x.Name == seller.Name && x.Age == seller.Age && x.Position == seller.Position)
                .Select(x => x.Reputation = x.Reputation + 1);
        }

        public void GiveBadReviewToSeller(Seller seller, Store store)
        {
            //decrease reputation of seller
            store.ShopAssistants
                .Where(x => x.Name == seller.Name && x.Age == seller.Age && x.Position == seller.Position)
                .Select(x => x.Reputation = x.Reputation - 1);
        }

        public void MakeVetAppointment(Vet vet, DateTime date, Store store)
        {
            //add na appointment with this customer to given vet's list with appointments
            Vet vetToAppoint =
                (from v in store.Vets
                 where v.Name == vet.Name && v.Age == vet.Age
                 select v).First();

            vetToAppoint.AddAppointment(new Appointment(this, date));
            //TODO: handle collision of appointments
        }

    }
}
