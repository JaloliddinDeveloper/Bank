namespace Bank.Classes
{
    public class Client
    {
        public string Name { get; }
        public string AccountNumber { get; }

        public Client(string name, string accountNumber)
        {
            Name = name;
            AccountNumber = accountNumber;
        }
    }
}
