namespace Interfaces
{
    #region IReservable
    /// <summary>
    /// Contract for items that can be reserved.
    /// </summary>
    public interface IReservable
    {
        /// <summary>
        /// Reserves the item for a user.
        /// </summary>
        public void Reserve();
    }
    #endregion

    #region INotifiable
    /// <summary>
    /// Contract for items that can send user notifications.
    /// </summary>
    public interface INotifiable
    {
        /// <summary>
        /// Notifies the user about the item status.
        /// </summary>
        public void Notify();
    }
    #endregion
}