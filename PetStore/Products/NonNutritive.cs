using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Products
{
    public class NonNutritive : PetProduct
    {
        // the type of the product e.g. collar, toy, appliance, other
        // the varety of Non Nutritive products is huge so no enum can handle this, leaving it as a string
        private string type;

        public NonNutritive(string name, double price, int inStock = 1, int rating = 0, string description = "", string priceFor = "", string targetAnimal = "", string type = "undefined")
            : base(name, price, inStock, rating, description, priceFor, targetAnimal)
        {
            this.Type = type;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
