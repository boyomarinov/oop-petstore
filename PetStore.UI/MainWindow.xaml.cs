using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using PetStore;
using PetStore.Animals;
using PetStore.People;
using PetStore.Products;

namespace PetStore.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Store store;
        static string selectedAnimal;

        public MainWindow()
        {
            InitializeComponent();

            //----------INIT STORE-----------------------------------------
            store = new Store();
            store.PopulateData();

            //---------INIT Elements--------------------------------------
            CustomersList.Items.Add("Select customer");
            for (int i = 0; i < store.Customers.Count; i++)
            {
                CustomersList.Items.Add(store.Customers[i].Name);
            }
            CustomersList.AllowDrop = true;
            CustomersList.SelectedIndex = 0;

            SellerList.Items.Add("Select shop assistant");
            for (int i = 0; i < store.ShopAssistants.Count; i++)
            {
                SellerList.Items.Add(store.ShopAssistants[i].Name);
            }
            SellerList.AllowDrop = true;
            SellerList.SelectedIndex = 0;

            #region Init Manager

            managerPhoto.BeginInit();
            managerPhoto.Source = new BitmapImage(new Uri(@"..\..\images\manager.jpg", UriKind.RelativeOrAbsolute));
            managerPhoto.EndInit();

            managerName.Content = store.StoreManager.Name;
            managerAge.Content = store.StoreManager.Age;

            List<Seller> sellers = new List<Seller>();
            for (int i = 0; i < store.ShopAssistants.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = store.ShopAssistants[i].ToString();

                ShopAssistantsList.Items.Add(tb);
            }

            List<Animal> allPets = new List<Animal>();
            List<PetProduct> allProducts = new List<PetProduct>();

            for (int i = 0; i < store.Pets.Count; i++)
            {
                TextBlock tb1 = new TextBlock();
                tb1.Text = store.Pets[i].ToString();

                AvailablePetsAndProducts.Items.Add(tb1);
            }


            for (int i = 0; i < store.PetProducts.Count; i++)
            {
                TextBlock tb2 = new TextBlock();
                tb2.Text = store.PetProducts[i].ToString();

                AvailablePetsAndProducts.Items.Add(tb2);
            }
            #endregion
        }

        //-------------------TAB1 - Pets -----------------------------------------

        //Show All Animals
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();
            selectedAnimal = "all";

            StackPanel sp = new StackPanel();
            //StackPanel row = new StackPanel();
            for (int i = 0; i < store.Pets.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = store.Pets[i].ToString();
                //row.Children.Add(tb);

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Display all cats
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();
            selectedAnimal = "cat";

            List<Cat> cats = new List<Cat>();

            for (int i = 0; i < store.Pets.Count; i++)
            {
                if (store.Pets[i] is Cat)
                {
                    cats.Add(store.Pets[i] as Cat);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < cats.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = cats[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Display all dogs
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();
            selectedAnimal = "dog";

            List<Dog> cats = new List<Dog>();

            for (int i = 0; i < store.Pets.Count; i++)
            {
                if (store.Pets[i] is Dog)
                {
                    cats.Add(store.Pets[i] as Dog);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < cats.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = cats[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Display all birds
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();
            selectedAnimal = "bird";

            List<Bird> cats = new List<Bird>();

            for (int i = 0; i < store.Pets.Count; i++)
            {
                if (store.Pets[i] is Bird)
                {
                    cats.Add(store.Pets[i] as Bird);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < cats.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = cats[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Display all reptiles
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();
            selectedAnimal = "reptile";

            List<Reptile> cats = new List<Reptile>();

            for (int i = 0; i < store.Pets.Count; i++)
            {
                if (store.Pets[i] is Reptile)
                {
                    cats.Add(store.Pets[i] as Reptile);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < cats.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = cats[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Display all rodents
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();
            selectedAnimal = "rodent";

            List<Rodent> cats = new List<Rodent>();

            for (int i = 0; i < store.Pets.Count; i++)
            {
                if (store.Pets[i] is Rodent)
                {
                    cats.Add(store.Pets[i] as Rodent);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < cats.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = cats[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Display all fish
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();
            selectedAnimal = "fish";

            List<Fish> cats = new List<Fish>();

            for (int i = 0; i < store.Pets.Count; i++)
            {
                if (store.Pets[i] is Fish)
                {
                    cats.Add(store.Pets[i] as Fish);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < cats.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = cats[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Sort animals by age
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();

            List<Animal> sorted = store.SortAge(selectedAnimal);

            StackPanel sp = new StackPanel();

            for (int i = 0; i < sorted.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = sorted[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Sort animals by breed
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();

            List<Animal> sorted = store.SortBreed(selectedAnimal);

            StackPanel sp = new StackPanel();

            for (int i = 0; i < sorted.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = sorted[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }

        //Sort animals by gender
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            AnimalList.Children.Clear();

            List<Animal> sorted = store.SortGender(selectedAnimal);

            StackPanel sp = new StackPanel();

            for (int i = 0; i < sorted.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = sorted[i].ToString();

                sp.Children.Add(tb);
            }

            AnimalList.Children.Add(sp);
        }



        //--------------------------------TAB2 PRODUCTS--------------------------------------------------

        //Display all products
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ProductList.Children.Clear();

            StackPanel sp = new StackPanel();
            //StackPanel row = new StackPanel();
            for (int i = 0; i < store.PetProducts.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = store.PetProducts[i].ToString();
                //row.Children.Add(tb);

                sp.Children.Add(tb);
            }

            ProductList.Children.Add(sp);
        }

        //Display all nutritive products
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            ProductList.Children.Clear();

            List<Nutritive> nutritives = new List<Nutritive>();

            for (int i = 0; i < store.PetProducts.Count; i++)
            {
                if (store.PetProducts[i] is Nutritive)
                {
                    nutritives.Add(store.PetProducts[i] as Nutritive);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < nutritives.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = nutritives[i].ToString();

                sp.Children.Add(tb);
            }

            ProductList.Children.Add(sp);
        }

        //Display all non nutritive products
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ProductList.Children.Clear();

            List<NonNutritive> nonNutritives = new List<NonNutritive>();

            for (int i = 0; i < store.PetProducts.Count; i++)
            {
                if (store.PetProducts[i] is NonNutritive)
                {
                    nonNutritives.Add(store.PetProducts[i] as NonNutritive);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < nonNutritives.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = nonNutritives[i].ToString();

                sp.Children.Add(tb);
            }

            ProductList.Children.Add(sp);
        }

        //Display all medicine
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            ProductList.Children.Clear();

            List<Medicine> medicines = new List<Medicine>();

            for (int i = 0; i < store.PetProducts.Count; i++)
            {
                if (store.PetProducts[i] is Medicine)
                {
                    medicines.Add(store.PetProducts[i] as Medicine);
                }
            }

            StackPanel sp = new StackPanel();

            for (int i = 0; i < medicines.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = medicines[i].ToString();

                sp.Children.Add(tb);
            }

            ProductList.Children.Add(sp);
        }

        //Handle the change of customer
        private void CustomersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Get current customer
            string currentCustomer = CustomersList.SelectedItem.ToString();

            //clear data
            PurchasedPetsAndProducts.Items.Clear();
            PetsAndProducts.Items.Clear();

            if (currentCustomer != "Select customer")
            {
                #region PurchasedPetsAndProductsStackPanel
                Customer c = store.Customers.Find(
                delegate(Customer cust)
                {
                    return cust.Name == currentCustomer;
                });

                //Populate customer labels
                customerName.Content = c.Name;
                customerAge.Content = c.Age.ToString();
                customerPhone.Content = c.PhoneNumber;

                //Add purchased pets
                if (c.CustomerPets.Count > 0)
                {
                    List<Animal> cPets = c.CustomerPets;
                    for (int i = 0; i < cPets.Count; i++)
                    {
                        TextBlock tb = new TextBlock();
                        tb.Text = cPets[i].ToString();

                        PurchasedPetsAndProducts.Items.Add(tb);
                    }
                }

                //Add purchased products
                if (c.PurchasedProducts.Count > 0)
                {
                    List<PetProduct> cProducts = c.PurchasedProducts;
                    for (int i = 0; i < cProducts.Count; i++)
                    {
                        TextBlock tb2 = new TextBlock();
                        tb2.Text = cProducts[i].ToString();

                        PurchasedPetsAndProducts.Items.Add(tb2);
                    }

                }
                #endregion

                #region AllPetsAndProductsStackPanel
                List<Animal> allPets = new List<Animal>();
                List<PetProduct> allProducts = new List<PetProduct>();

                for (int i = 0; i < store.Pets.Count; i++)
                {
                    TextBlock tb3 = new TextBlock();
                    tb3.Text = store.Pets[i].ToString();

                    PetsAndProducts.Items.Add(tb3);
                }


                for (int i = 0; i < store.PetProducts.Count; i++)
                {
                    TextBlock tb4 = new TextBlock();
                    tb4.Text = store.PetProducts[i].ToString();

                    //sp4.Children.Add(tb4);
                    PetsAndProducts.Items.Add(tb4);
                }

                #endregion
            }




        }

        #region BuyProduct
        private void RefreshProducts(Customer c)
        {
            //Update purchased products
            PurchasedPetsAndProducts.Items.Clear();
            for (int i = 0; i < c.CustomerPets.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = c.CustomerPets[i].ToString();

                PurchasedPetsAndProducts.Items.Add(tb);
            }
            for (int i = 0; i < c.PurchasedProducts.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = c.PurchasedProducts[i].ToString();

                PurchasedPetsAndProducts.Items.Add(tb);
            }

            //Update store products
            PetsAndProducts.Items.Clear();
            for (int i = 0; i < store.Pets.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = store.Pets[i].ToString();

                PetsAndProducts.Items.Add(tb);
            }
            for (int i = 0; i < store.PetProducts.Count; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Text = store.PetProducts[i].ToString();

                PetsAndProducts.Items.Add(tb);
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            int index = PetsAndProducts.SelectedIndex;
            if (index == -1)
            {
                //Nothing
            }
            else
            {
                string currentCustomer = CustomersList.SelectedItem.ToString();
                Customer current = store.Customers.Find(
                        delegate(Customer c)
                        {
                            return c.Name == currentCustomer;
                        });

                //if customer is buying a pet
                if (index < store.Pets.Count)
                {
                    Animal toBuy = store.Pets[index];
                    current.BuyNewPet(toBuy, store);
                }
                //if customer is buying a product
                else
                {
                    PetProduct toBuy = store.PetProducts[index];
                    current.BuyProduct(toBuy, store);
                }

                RefreshProducts(current);
            }
        }

        #endregion



        //---------------------------TAB3 - SELLER ---------------------------------------

        private void SellerList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //Get current customer
            string currentSeller = SellerList.SelectedItem.ToString();

            //clear data
            AllPetsAndProducts.Items.Clear();

            if (currentSeller != "Select shop assistant")
            {
                Seller s = store.ShopAssistants.Find(
                delegate(Seller sel)
                {
                    return sel.Name == currentSeller;
                });

                //Populate customer labels
                sellerName.Content = s.Name;
                sellerAge.Content = s.Age.ToString();
                sellerPosition.Content = s.Position.ToString();
                sellerSalary.Content = s.Salary.ToString();
                sellerReputation.Content = s.Reputation.ToString();

                #region AllPetsAndProductsStackPanel
                List<Animal> allPets = new List<Animal>();
                List<PetProduct> allProducts = new List<PetProduct>();

                for (int i = 0; i < store.Pets.Count; i++)
                {
                    TextBlock tb3 = new TextBlock();
                    tb3.Text = store.Pets[i].ToString();

                    AllPetsAndProducts.Items.Add(tb3);
                }


                for (int i = 0; i < store.PetProducts.Count; i++)
                {
                    TextBlock tb4 = new TextBlock();
                    tb4.Text = store.PetProducts[i].ToString();

                    //sp4.Children.Add(tb4);
                    AllPetsAndProducts.Items.Add(tb4);
                }

                #endregion
            }

        }
    }
}
