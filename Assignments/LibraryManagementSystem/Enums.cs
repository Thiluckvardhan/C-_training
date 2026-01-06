/// <summary>
/// Enumerations for roles and item lifecycle states.
/// </summary>
namespace LibraryManagementSystem
{
    #region Enums
    public enum UserRole
    {
        Admin,
        Librarian,
        Member
    }

    public enum ItemStatus
    {
        Available,
        Borrowed,
        Reserved,
        Lost
    }
    #endregion
}
