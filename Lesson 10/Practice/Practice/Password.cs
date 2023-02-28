namespace Practice
{
    class Password
    {
        public string confirmPassword;

        public string Value { get; set; } = "";
        public string ConfirmPassword
        {
            get => confirmPassword;
            set
            {
                if (!value.Equals(Value))
                    throw new PasswordException("Пароли не совпадают ошибка");
                else
                    confirmPassword = value;
            }
        }
    }

}