namespace LearningCSharp
{
    /// <summary>
    /// Demonstrates the use of private setters in C#.
    /// Shows how to restrict property modification while allowing reading.
    /// </summary>
    public class YoungProfessional
    {
        /// <summary>
        /// Default constructor for the YoungProfessional class.
        /// </summary>
        public YoungProfessional()
        {
            
        }
        
        /// <summary>
        /// Constructor that initializes the date of birth.
        /// </summary>
        /// <param name="dob">The date of birth string</param>
        public YoungProfessional(string dob)
        {
            DateOfBirth = dob;

        }
        
        // Gets or sets the personal ID. Has a private setter, so it can only be modified internally.
        public int PersonalId { get; private set; }
        
        // Gets or sets the registration number. Can be modified publicly.
        public int RNo { get; set; }
        
        // Gets or sets the date of birth. Has a private setter, so it can only be modified internally.
        public string DateOfBirth { get; private set; }

        // Gets or sets the name of the professional.
        public string Name { get; set; }
        

        /// <summary>
        /// Sets the date of birth through a public method.
        /// Provides an alternative way to modify the private property.
        /// </summary>
        /// <param name="dateOfBirth">The date of birth to set</param>
        public void SetDateOfBirth(string dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

    }
}