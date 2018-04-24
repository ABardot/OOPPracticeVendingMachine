using System;

namespace Ch4_Vending
{
    internal class VendingMachine
    {
        private int depositedAmount;
        private const int COST_OF_DRINK = 75; // Set the cost of the beverage in order to prevent magic numbers and cost can be changes once.

        public VendingMachine()
        {
            depositedAmount = 0;
        }

        public void DepositCoin(int coinAmount)
        {
            depositedAmount += coinAmount;
        }

        public void getDrink()
        {
            if (depositedAmount >= 75)
            {    // This will calculation the amount deposited - cost of beverage
                Console.WriteLine("Your change is {0:} cents", depositedAmount - COST_OF_DRINK);
                depositedAmount = 0; // Call the method to set deposited amount to Zero.
            }
            else
            {
                Console.WriteLine("Insert More Coins"); // Prompts user to add more coins to meet value of the beverage
            }
        }

        public void getRefund()
        {
            Console.WriteLine("You were refunded {0}", depositedAmount); // Deposit money to user
        }
    }
}