namespace Day18
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string ConfirmationPassword { get; set; }
    }

    public class Question6
    {
        public User ValidatePassword(string name, string password, string confirmationPassword)
        {
            User user=new();
            if (password != confirmationPassword)
            {
                throw new PasswordMismatchException();
            }
            user.Name=name;
            user.Password=password;
            user.ConfirmationPassword=confirmationPassword;
            return user;
        }
    }

    public class PasswordMismatchException : Exception
    {
        public PasswordMismatchException() : base("Password entered does not match")
        {

        }
    }
}