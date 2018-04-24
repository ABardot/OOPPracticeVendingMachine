using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Vending
{
    class VendingMachine
    {
        private int depositedAmount;
        const int COST_OF_DRINK = 75; // Set the cost of the beverage in order to prevent magic numbers and cost can be changes once. 

        public VendingMachine()
        {
            depositedAmount = 0;
        }

        public void DepositCoin(int coinAmount)
        {
            depositedAmount = coinAmount;
        }

        public void getDrink()
        {
            if (depositedAmount >= 75)
            {    // This will calculation the amount deposited - cost of beverage 
                Console.WriteLine("Your change is {0:} cents", depositedAmount - COST_OF_DRINK);
                DepositCoin(0); // Call the method to set deposited amount to Zero.
            }
            else
            {

            }
        }

    }
}
