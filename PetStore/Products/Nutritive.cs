using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Products
{
    public class Nutritive : PetProduct
    {
        public FootType FoodType{ get; set; }

        public Nutritive(string name, double price, int inStock = 1, int rating = 0, string description = "", string priceFor = "", string targetAnimal = "", FootType type = FootType.Undefined)
            : base(name, price, inStock, rating, description, priceFor, targetAnimal)
        {
            this.FoodType = type;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, InStock: {2}, Rating: {3}",
                this.Name, this.Price, this.InStock, this.Rating);
        }
    }
}
