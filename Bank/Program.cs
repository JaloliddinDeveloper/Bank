using Bank.Classes;
public class Program
{
    private static void Main(string[] args)
    {
        Securety securety = new Securety();
        securety.Checkpassword();
      Bank_ bank=new Bank_();

        Client client1 = new Client("Ali",  "1111");
        Client client2 = new Client("Vali", "2222");
        Client client3 = new Client("Sobir","3333");


        bank.OpenAccount(client1);
        bank.OpenAccount(client2);
        bank.OpenAccount(client3);

        bank.ShowAllBalances();
        BankAccount account1 = bank.accounts.Find(acc => acc.AccountNumber == client1.AccountNumber);
        BankAccount account2 = bank.accounts.Find(acc => acc.AccountNumber == client2.AccountNumber);
        BankAccount account3 = bank.accounts. Find(acc => acc.AccountNumber == client3.AccountNumber);

        account1.Deposit(2_000_000);
        account2.Deposit(0);
        account3.Deposit(4_000_000);

       

        bank.TransferMoney(account1, account2,2000000);
        bank.TransferMoney(account3, account2,2000000);

        bank.ShowAllBalances();

        bank.CloseAccount(client3);

        bank.ShowAllBalances();
    }
}