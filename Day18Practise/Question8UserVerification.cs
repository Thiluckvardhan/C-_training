namespace Day18
{
    /// <summary>Stores user contact details for verification.</summary>
    public class Users
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
    }

    /// <summary>Validates user phone numbers and reports invalid entries.</summary>
    public class Question8
    {
        public Users ValidatePhoneNumber(string name, string phoneNumber)
        {
            if (phoneNumber.Length == 10)
            {
                // Accept when the phone number meets the required length
                return new Users { Name = name, PhoneNumber = phoneNumber };
            }
            // Signal failure for invalid phone numbers
            throw new InvalidPhoneNumberException();
        }

        /// <summary>Raised when a provided phone number fails validation rules.</summary>
        public class InvalidPhoneNumberException : Exception
        {
            public InvalidPhoneNumberException() : base("Invalid Phone Number") { }
        }
    }
}