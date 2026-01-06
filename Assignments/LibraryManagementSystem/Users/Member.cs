/// <summary>
/// User representation with assigned role for the library system.
/// </summary>
namespace LibraryManagementSystem.Users
{
    using LibraryManagementSystem;

    public class Member
    {
        #region Properties
        public string? Name { get; set; }
        public UserRole Role { get; set; }
        #endregion
    }
}
