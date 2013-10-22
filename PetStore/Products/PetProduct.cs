using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Products
{
    public abstract class PetProduct
    {
        private string name;
        private double price;
        private int inStock;
        private int rating;
        // short product description
        private string description;
        // the product price is for kg, liter, pack, undefined
        // todo enum
        private string priceFor;
        // for what animal is the product
        private string targetAnimal;

        public PetProduct(string name, double price, int inStock = 1, int rating = 0, string description = "", string priceFor = "", string targetAnimal = "")
        {
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Rating = rating;
            this.Description = description;
            this.PriceFor = priceFor;
            this.TargetAnimal = targetAnimal;
        }

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int InStock
        {
            get { return inStock; }
            set { inStock = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string PriceFor
        {
            get { return priceFor; }
            set { priceFor = value; }
        }

        public string TargetAnimal
        {
            get { return targetAnimal; }
            set { targetAnimal = value; }
        }

        #endregion

        public override string ToString()
        {
            return String.Format("{0}, Price: {1}, InStock: {2}, Rating: {3}, Description: {4}",
                                this.Name, this.Price, this.InStock, this.Rating, this.Description);
        }
    }
}
