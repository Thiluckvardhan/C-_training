namespace Day18
{
    public class Users
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
    }

    public class Question8
    {
        public Users ValidatePhoneNumber(string name, string phoneNumber)
        {
            if (phoneNumber.Length == 10)
            {
                return new Users { Name = name, PhoneNumber = phoneNumber };
            }
            throw new InvalidPhoneNumberException();
        }

        public class InvalidPhoneNumberException : Exception
        {
            public InvalidPhoneNumberException() : base("Invalid Phone Number") { }
        }
    }
}