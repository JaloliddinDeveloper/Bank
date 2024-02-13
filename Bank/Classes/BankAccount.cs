namespace Bank.Classes
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber, double balance = 0)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Buncha mablag' yetarli emas hisobda");
            }
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
