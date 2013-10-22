using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Products
{
    public class Medicine : PetProduct
    {
        // a path to document containing the prescription
        private string prescription;
        private string warning;

        public MedicineType MedicineType { get; set; }

        public Medicine(string name, double price, int inStock = 1, int rating = 1, string description = "", string priceFor = "", string targetAnimal = "", string prescription = "", string warning = "", MedicineType medicineType = MedicineType.Undefined)
            : base(name, price, inStock, rating, description, priceFor, targetAnimal)
        {
            this.Warning = warning;
            this.Prescription = prescription;
            this.MedicineType = medicineType;
        }

        #region Properties
        public string Warning
        {
            get { return warning; }
            set { warning = value; }
        }
        
        public string Prescription
        {
            get { return prescription; }
            set { prescription = value; }
        }
        #endregion

        public override string ToString()
        {
            return String.Format("{0}, {1}, InStock: {2}, Rating: {3}",
                this.Name, this.Price, this.InStock, this.Rating);
        }
    }
}
