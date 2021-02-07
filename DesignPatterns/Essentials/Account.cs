using System;

namespace DesignPatterns
{
    public class Account
    {
        public float Balance { get; private set; }

        public void Deposit(float amount)
        {
            if (amount > 0) {
                this.Balance += amount;
            }
        }

        public void Withdraw(float amount)
        {
            if (amount > 0) {
                this.Balance -= amount;
            }
        }
    }
}
