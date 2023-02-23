namespace Practice
{
    class AccountInformation
    {
        private int accountId;
        private string accountName;
        private decimal deposit;
        private DateTime openedDate;
        private char accountType;

        public AccountInformation()
        {
            openedDate = DateTime.Now;
        }

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        public int AccountType
        {
            get { return accountType; }
            set { accountType = (char)value; }
        }

        public decimal Deposit
        {
            get { return deposit; }
            set
            {
                if (deposit >= 0)
                { deposit = value; }
                else
                { Console.WriteLine("Депозит не может быть в минусе"); }
            }
        }
        public DateTime OpenedDate
        {
            get { return openedDate; }
            set { openedDate = value; }
        }

    }
}