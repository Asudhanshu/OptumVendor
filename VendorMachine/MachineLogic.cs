using System;

namespace VendorMachine
{
    /// <summary>
    /// The purpose of this class is to write the logic for purchasing of product. 
    /// </summary>
    class MachineLogic
    {
        private float UserAmount { get; set; }
        private bool check = true;
        /// <summary>
        /// Constructor to call logic and initialize the total amount entered by user in machine.
        /// </summary>
        /// <param name="userAmount"></param>
        public MachineLogic(float userAmount)
        {
            this.UserAmount = userAmount;
            this.Logic();
        }
        /// <summary>
        /// The purpose of this method is to write the logic for purchasing of products 
        /// </summary>
        private void Logic()
        {
            AcceptingProducts products = new AcceptingProducts();
            while (check)
            {
                int productNumber;
                bool value = int.TryParse(Console.ReadLine(), out productNumber);
                if (!value)
                {
                    Console.WriteLine("Wrong Products selected, Returning back");
                    Console.WriteLine($"Please collect the remaining amount {this.UserAmount}");
                    break;
                }
                var product = products.ChooseProduct(productNumber);
                if (product.Price > UserAmount)
                {
                    Console.WriteLine("InSufficient Balance");
                 
                }
                else
                {
                    this.UserAmount = this.UserAmount - product.Price;
                    Console.WriteLine($"Thank you for purchasing, Balance Amount {this.UserAmount}");
                }
                if (UserAmount <= 0.5)
                {
                    check = false;
                    Console.WriteLine($"Thank you for purchasing {product.Name}, Please collect the remaining {this.UserAmount}$");
                }
                else
                {
                    Console.WriteLine("Press Y if you want to purchase more products, Else press N");
                    string confirm = Console.ReadLine();
                    if (!(confirm.Equals("Y") || confirm.Equals("y")) || UserAmount <= 0.5)
                    {
                        check = false;
                    }
                }
                
            }
        }
    }
}
