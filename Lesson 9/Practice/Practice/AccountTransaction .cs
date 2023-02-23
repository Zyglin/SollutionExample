namespace Practice
{
    class AccountTransaction : AccountInformation, ITransaction
    {

        public void CreateAccount()
        {
            Console.WriteLine("-----Введите информацию об Аккаунте-----");
            Console.Write("Аккаунт Id: ");
            AccountId = int.Parse(Console.ReadLine());
            Console.Write("Имя Аккаунта: ");
            AccountName = Console.ReadLine();
            Console.Write("Тип Аккаунта [Комерческий/Персональный - (C/P)]: ");
            AccountType = char.Parse(Console.ReadLine());
            Console.Write("Депозит: ");
            Deposit = int.Parse(Console.ReadLine());
        }
        public void ShowAccount()
        {
            Console.WriteLine("-------Информация об Аккаунте-------");
            Console.WriteLine($"Аккаунт Id: {AccountId}");
            Console.WriteLine($"Имя Аккаунта {AccountName}");
            Console.WriteLine($"Тип Аккаунта: {AccountType}");
            Console.WriteLine($"Баланс Аккаунта: {Deposit}");
            Console.WriteLine($"Дата открытия аккаунта: {OpenedDate.ToString("dd-MM-yyyy HH:mm")}");
            Console.WriteLine($"---------------------------------");
        }


        public void ModifyAccount(int acccountiD)
        {
            if (acccountiD == AccountId)
            {
                Console.WriteLine("\n-------*Обновление Аккаунта*------");
                Console.WriteLine($"Аккаунт Id : {AccountId}");
                Console.Write($"Обновить имя Аккаунта : ");
                AccountName = Console.ReadLine();
                Console.Write("Обновить тип Аккаунта [Комерческий/Персональный (C/P)]: ");
                AccountType = char.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Не правильный Id Аккаунта !!! Попробуйте снова....\n");
            }
        }


        public void MoneyDeposit()
        {
            decimal amount;
            Console.Write("Введите сколько хотите внести Депозит: ");
            amount = decimal.Parse(Console.ReadLine());
            Deposit += amount;
        }


        public void MoneyWithdraw() 
        {
            decimal amount;
            Console.Write("Введите сколько хотите вывести денег: ");
            amount = decimal.Parse(Console.ReadLine());
            Deposit -= amount;
        }


        public void AccountReport()
        {
            Console.WriteLine("\n----------Информация о балансе----------");
            Console.WriteLine($"Аккаунт Id {AccountId}");
            Console.WriteLine($"Баланс {Deposit}");
        } 

    }
}