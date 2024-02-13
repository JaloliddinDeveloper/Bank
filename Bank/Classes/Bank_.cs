namespace Bank.Classes
{
    public class Bank_
    {
        public List<BankAccount> accounts = new List<BankAccount>();

        public void OpenAccount(Client client)
        {
            BankAccount newAccount = new BankAccount(client.AccountNumber);
            accounts.Add(newAccount);
            Console.WriteLine($"{client.Name} uchun hisob ochildi");
        }

        public void CloseAccount(Client client)
        {
            BankAccount accountToClose = accounts.Find(acc => acc.AccountNumber == client.AccountNumber);
            if (accountToClose != null)
            {
                accounts.Remove(accountToClose);
                Console.WriteLine($"{client.Name} uchun hisob yopildi");
            }
            else
            {
                Console.WriteLine("ushbu hisob topilmadi");
            }
        }

        public void TransferMoney(BankAccount fromAccount, BankAccount toAccount, double amount)
        {
            if (fromAccount.Balance >= amount)
            {
                fromAccount.Withdraw(amount);
                toAccount.Deposit(amount);
                Console.WriteLine("O‘tkazma muvaffaqiyatli amalga oshirildi");
            }
            else
            {
                Console.WriteLine("O'tkazma uchun mablag' yetarli emas");
            }
        }

        public void ShowAllBalances()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Hisob raqam: {account.AccountNumber}, Balans: {account.GetBalance()}");
            }
        }
    }
}
