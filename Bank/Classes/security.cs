namespace Bank.Classes
{
    class Securety
    {
        public void Checkpassword()
        {
            string password = "";

            do
            {
                Console.Write("enter your password: ");
                password = Console.ReadLine();
            }
            while (password != "pa$$w0rd");
        }

    }
}
