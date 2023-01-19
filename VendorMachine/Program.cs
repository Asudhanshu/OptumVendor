using System;

namespace VendorMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Vendor Service!");
            Console.WriteLine("Please Enter the coin in the machine");
            
            AcceptingCoins acceptCoins = new AcceptingCoins();
            bool check = true;
            int a;
            while (check)
            {
                bool value = int.TryParse(Console.ReadLine(),out a);
                if (!value)
                {
                    Console.WriteLine("Wrong values inserted!!");
                    break;
                }
                else
                {
                    acceptCoins.SelectCoin(a);
                }
                Console.WriteLine("Press Y if you want to enter more coins, Else press N");
                string confirm = Console.ReadLine();
                if (!(confirm.Equals("Y") || confirm.Equals("y")))
                {
                    check = false;
                }
            }
            Console.WriteLine($"Your Total Amount is {acceptCoins.FinalAmount()}");
            if (acceptCoins.FinalAmount() > 0)
            {
                Console.WriteLine("Please select from the list of below products");
                MachineLogic machineLogic = new MachineLogic(acceptCoins.FinalAmount());
            }
            else
            {
                Console.WriteLine("Thank you for coming!!");
            }
        }
    }
}
