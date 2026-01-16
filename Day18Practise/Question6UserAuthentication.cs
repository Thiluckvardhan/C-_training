namespace Day18
{
    /// <summary>Represents user credentials submitted for validation.</summary>
    public class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? ConfirmationPassword { get; set; }
    }

    /// <summary>Validates user password entries and ensures confirmation matches.</summary>
    public class Question6
    {
        public User ValidatePassword(string name, string password, string confirmationPassword)
        {
            User user=new();
            if (password != confirmationPassword)
            {
                // Reject when confirmation does not match the original password
                throw new PasswordMismatchException();
            }
            // Persist the validated credentials
            user.Name=name;
            user.Password=password;
            user.ConfirmationPassword=confirmationPassword;
            return user;
        }
    }

    /// <summary>Raised when the provided password and confirmation do not match.</summary>
    public class PasswordMismatchException : Exception
    {
        public PasswordMismatchException() : base("Password entered does not match")
        {

        }
    }
}