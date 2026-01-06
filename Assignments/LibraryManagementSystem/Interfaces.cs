/// <summary>
/// Interface contracts for reservations and notifications in the library domain.
/// </summary>
namespace LibraryManagementSystem
{
    #region Interfaces
    public interface IReservable
    {
        void Reserve();
    }

    public interface INotifiable
    {
        void Notify(string message);
    }
    #endregion
}
