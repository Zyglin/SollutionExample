namespace Practice
{
    class Login
    {
        public string Password { get; set; }

        public void SignIn()
        {
            Console.Write("Enter your Password: ");
            Password = Console.ReadLine();
            if (Password == "123")
            {
                Console.WriteLine("Welcome to Admin Screen");
            }
            else
            {
                Console.WriteLine("Welcome to Customer Screen");
            }
            Thread.Sleep(300);
            Console.Clear();


        }

    }
}