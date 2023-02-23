namespace Practice
{
    interface ITransaction 
    {
        public void CreateAccount();
        public void ShowAccount();
        public void ModifyAccount(int acccountiD);
        public void MoneyDeposit();
        public void MoneyWithdraw();
        public void AccountReport();

    }
}