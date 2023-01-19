using System;

namespace VendorMachine
{
    /// <summary>
    /// The purpose of this class is to create the products, display them and Select products
    /// </summary>
    public class AcceptingProducts
    {
        /// <summary>
        /// Initializing different products
        /// </summary>
        private Products Cola = new Products() {Name="Cola", Price=1.0f };
        private Products Chips = new Products() { Name = "Chips", Price = 0.5f };
        private Products Candy = new Products() { Name = "Candy", Price = 0.65f };
        public AcceptingProducts()
        {
            DisplayProducts();
        }
        private void DisplayProducts()
        {
            Console.WriteLine($"1.{Cola.Name} - {Cola.Price}");
            Console.WriteLine($"2.{Chips.Name} - {Chips.Price}");
            Console.WriteLine($"3.{Candy.Name} - {Candy.Price}");
        }
        /// <summary>
        /// This function will return the products choosen by customer
        /// </summary>
        /// <returns></returns>
        public Products ChooseProduct(int productNumber)
        {
            switch (productNumber)
            {
                case 1:
                    return Cola;
                case 2:
                    return Chips;
                case 3:
                    return Candy;
                default:
                    return null;
            }
        }
    }
}
