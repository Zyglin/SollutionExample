using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntroductionStruct intro = new IntroductionStruct();
            AccountTransaction transaction = new AccountTransaction();
            Login signin = new Login();
            int opt;

            intro.Intro();
            intro.Loading();
            Console.Clear();

            do
            {
                Console.Write("\n\n\tОсновное Меню");
                Console.Write("\n\t1. Новый Аккаунт");
                Console.Write("\n\t2. Показать Аккаунт");
                Console.Write("\n\t3. Обновить Аккаунт");
                Console.Write("\n\t4. Внести Деньги");
                Console.Write("\n\t5. Вывести Деньги");
                Console.Write("\n\t6. Показать Баланс");
                Console.Write("\n\t7. Выход");
                Console.Write("\n\tВыберите Пункты (1-7)...: ");
                opt = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opt)
                {
                    case (int)Option.New:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.CreateAccount();
                            break;
                        }
                    case (int)Option.Show:
                        {
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            transaction.ShowAccount();
                            break;
                        }
                    case (int)Option.Modify:
                        {
                            int acno;
                            Console.Clear();
                            intro.Loading();
                            Console.Clear();
                            Console.Write("Введите Аккаунт Id : ");
                            acno = int.Parse(Console.ReadLine());
                            transaction.ModifyAccount(acno);
                            break;
                        }
                    case (int)Option.Deposit:
                        {
                            transaction.MoneyDeposit();
                            break;
                        }
                    case (int)Option.WithDraw:
                        {
                            transaction.MoneyWithdraw();
                            break;
                        }
                    case (int)Option.BalanceShow:
                        {
                            transaction.AccountReport();
                            break;
                        }
                    case (int)Option.Exit:
                        { Environment.Exit(0); break; }
                }
            } while (opt != (int)Option.Exit);
        
        }
    }
}