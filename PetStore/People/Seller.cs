using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore.Products;

namespace PetStore.People
{
    public class Seller : Person, ISeller
    {
        private SellerPosition position;
        private int workHours;
        private double salary;
        private int reputation;

        public Seller()
            : base()
        {
            this.Position = SellerPosition.Consultant;
            this.WorkHours = 4;
            this.salary = 900;
            this.reputation = 1;
        }

        public Seller(string name, uint age, int position, int workHours, double salary = 900, int reputation = 1)
            :base(name, age)
        {
            this.Position = (SellerPosition)position;
            this.WorkHours = workHours;
            this.Salary = salary;
            this.Reputation = reputation;
        }

        #region Properties
        public SellerPosition Position
        {
            get { return position; }
            set { position = value; }
        }

        public int WorkHours
        {
            get { return workHours; }
            set { workHours = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Reputation
        {
            get { return reputation; }
            set { reputation = value; }
        }
        #endregion

        //public bool Equals(Seller other)
        //{
        //    if ((object)other == null)
        //    {
        //        return false;
        //    }
        //    return (this.Name == other.Name) && (this.Age == other.Age) && (this.Position == other.Position);
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //    {
        //        return false;
        //    }

        //    Seller s = obj as Seller;
        //    if ((Object)s == null)
        //    {
        //        return false;
        //    }

        //    return (this.Name == s.Name) && (this.Age == s.Age) && (this.Position == s.Position);
        //}

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}\nHours: {3}, Salary: {4}, Reputation: {5}",
                this.Name, this.Age, this.Position, this.WorkHours, this.Salary, this.Reputation);
        }

        public void SellProduct(PetProduct product, Store store)
        {
            this.Reputation++;

            //InStock-- of product is done in Customer.BuyProduct() method
            //TODO: handle on both sides (client/seller) ?
        }

        public void SuggestProduct(Store store)
        {
            //Gets first 10- products from a list with highest rank and smallest price
            List<PetProduct> suggested =
                (from p in store.PetProducts
                 orderby p.Rating descending, p.Price ascending
                 select p).ToList<PetProduct>();

            if (suggested.Count < 10)
            {
                foreach (PetProduct p in suggested)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(suggested[i].ToString());
                }
            }
            
        }

    }
}
