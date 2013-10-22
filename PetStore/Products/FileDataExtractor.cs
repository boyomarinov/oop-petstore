using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Products
{
    public class FileDataExtractor : IDataFactory
    {
        // Products
        string name;
        double price;
        int inStock;
        int rating;
        string description;
        string priceFor;
        string targetAnimal;
        // NonNutritive
        string type;
        // Nutritive
        FootType ftype = FootType.Undefined;
        MedicineType medType = MedicineType.Undefined;
        // Medicine
        string prescription;
        string warning;
        
        public List<PetProduct> ExtactData()
        {
            return ReadAllProductDataFromFile();
        }

        public static List<PetProduct> ReadAllProductDataFromFile()
        {
            List<PetProduct> result = new List<PetProduct>();
            result.AddRange(ReadNonNutritive(@"..\..\..\PetStore\LoadDataFromFile\NonNutritive.txt"));
            result.AddRange(ReadNutritive(@"..\..\..\PetStore\LoadDataFromFile\Nutritive.txt"));
            result.AddRange(ReadMedicine(@"..\..\..\PetStore\LoadDataFromFile\Medicine.txt"));
            return result;
        }

        private static List<Medicine> ReadMedicine(string fileName)
        {
            List<Medicine> medicine = new List<Medicine>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = String.Empty;
                while ((line = readFile.ReadLine()) != null)
                {
                    medicine.Add(ReadMedicineLine(line));
                }
            }

            return medicine;
        }



        private static List<Nutritive> ReadNutritive(string fileName)
        {
            List<Nutritive> nutritive = new List<Nutritive>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = String.Empty;
                while ((line = readFile.ReadLine()) != null)
                {
                    nutritive.Add(ReadNutritiveLine(line));
                }
            }
            return nutritive;
        }

        

        public static List<NonNutritive> ReadNonNutritive(string fileName)
        {
            List<NonNutritive> nonNutritive = new List<NonNutritive>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = String.Empty;
                while ((line = readFile.ReadLine()) != null)
                {
                    nonNutritive.Add(ReadNonNutritiveLine(line));
                }
            }

            return nonNutritive;
        }

        private static NonNutritive ReadNonNutritiveLine(string line)
        {
            string[] splitLine = line.Split(',');
            FileDataExtractor fdx = new FileDataExtractor();
            GetBaseProperties(splitLine, fdx);
            fdx.type = splitLine[7].Trim();

            return new NonNutritive(fdx.name, fdx.price, fdx.inStock, fdx.rating, fdx.description, fdx.priceFor, fdx.targetAnimal, fdx.type);
        }
  
        private static Nutritive ReadNutritiveLine(string line)
        {
            string[] splitLine = line.Split(',');
            FileDataExtractor fdx = new FileDataExtractor();
            GetBaseProperties(splitLine, fdx);
            string tempType = splitLine[7].Trim();

            switch (tempType)
            {
                case "Other":
                    fdx.ftype = FootType.Other;
                    break;
                case "DryFood":
                    fdx.ftype = FootType.DryFood;
                    break;
                case "CanFood":
                    fdx.ftype = FootType.CanFood;
                    break;
                case "Drink":
                    fdx.ftype = FootType.Drink;
                    break;
                default:
                    fdx.ftype = FootType.Undefined;
                    break;
            }

            return new Nutritive(fdx.name, fdx.price, fdx.inStock, fdx.rating, fdx.description, fdx.priceFor, fdx.targetAnimal, fdx.ftype);
        }

        private static Medicine ReadMedicineLine(string line)
        {
            string[] splitLine = line.Split(',');
            FileDataExtractor fdx = new FileDataExtractor();
            GetBaseProperties(splitLine, fdx);

            // string prescription, string warning and MediciteType.MediciteType for Medicine Products
            fdx.prescription = splitLine[7].Trim();
            fdx.warning = splitLine[8].Trim();

            string tempType = splitLine[9].Trim();

            switch (tempType)
            {
                case "Antibiontic":
                    fdx.medType = MedicineType.Antibiontic;
                    break;
                case "Vitamin":
                    fdx.medType = MedicineType.Vitamin;
                    break;
                case "Homeopatic":
                    fdx.medType = MedicineType.Homeopatic;
                    break;
                case "Immune":
                    fdx.medType = MedicineType.Immune;
                    break;
                case "Special":
                    fdx.medType = MedicineType.Special;
                    break;
                default:
                    fdx.medType = MedicineType.Undefined;
                    break;
            }
           
            return new Medicine(fdx.name, fdx.price, fdx.inStock, fdx.rating, fdx.description, fdx.priceFor, fdx.targetAnimal, fdx.prescription, fdx.warning, fdx.medType);
        }

        private static void GetBaseProperties(string[] splitLine, FileDataExtractor fdx)
        {
            fdx.name = splitLine[0].Trim();
            fdx.price = double.Parse(splitLine[1].Trim());
            fdx.inStock = int.Parse(splitLine[2].Trim());
            fdx.rating = int.Parse(splitLine[3].Trim());
            fdx.description = splitLine[4].Trim();
            fdx.priceFor = splitLine[5].Trim();
            fdx.targetAnimal = splitLine[6].Trim();
        }
    }
}
