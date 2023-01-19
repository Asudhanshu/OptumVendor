using System;

namespace VendorMachine
{
    public class AcceptingCoins
    {
        private readonly bool check = true;
        private float Sum { get; set; }
        private Coins Nickel = new Coins() { CoinName = "Nickel", CoinValue = 0.05f };
        private Coins Quarters = new Coins() { CoinName = "Quarters", CoinValue = 0.25f };
        private Coins Dimes = new Coins() { CoinName = "Dimes", CoinValue = 0.10f };
        private Coins Dollar = new Coins() { CoinName = "Dollar", CoinValue = 1.0f };
        public AcceptingCoins()
        {
            DisplayCoin();
        }
        public void SelectCoin(int value)
        {
            switch (value)
            {
                case 1 :
                    TotalAmount(Nickel.CoinValue);
                    break;
                case 2 :
                    TotalAmount(Dimes.CoinValue);
                    break;
                case 3:
                    TotalAmount(Quarters.CoinValue);
                    break;
                case 4:
                    TotalAmount(Dollar.CoinValue);
                    break;
                default:
                    Console.WriteLine("Please enter a valid coin");
                    break;
            }       
        }
        private void DisplayCoin()
        {
            Console.WriteLine("1.Nickel 0.05$");
            Console.WriteLine("2.Dimes 0.1$");
            Console.WriteLine("3.Quarter 0.25$");
            Console.WriteLine("4.Dollar 1.0$");
            Console.WriteLine("5.Others 0.0$");
        }
        public float TotalAmount(float coinValue)
        {
            Sum += coinValue;
            return Sum;
        }
        public float FinalAmount()
        {
            return Sum;
        }
        
        
    }
}
