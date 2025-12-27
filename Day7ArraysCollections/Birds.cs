namespace Day7
{
    #region Bird Interfaces
    /// <summary>
    /// Describes flight and swimming behaviors.
    /// </summary>
    interface Bird1
    {
        /// <summary>
        /// Perform a flying action.
        /// </summary>
        public void Fly();
        /// <summary>
        /// Perform a swimming action.
        /// </summary>
        public void Swim();

        /// <summary>
        /// Perform a walking action common to ground movement.
        /// </summary>
        public void Walk();
    }

    /// <summary>
    /// Describes entertainment behaviors.
    /// </summary>
    interface Bird2
    {
        /// <summary>
        /// Perform a dance action.
        /// </summary>
        public void Dance();

        /// <summary>
        /// Perform a singing action.
        /// </summary>
        public void Sing();

        /// <summary>
        /// Perform a walking action common to ground movement.
        /// </summary>
        public void Walk();
    }
    #endregion

    #region Hybrid Bird Implementation
    /// <summary>
    /// Combines flight, swimming, dancing, and singing behaviors.
    /// </summary>
    public class HybridBird : Bird1, Bird2
    {
        /// <inheritdoc />
        public void Fly()
        {
            Console.WriteLine("Hybrid Bird can Fly");
        }

        /// <inheritdoc />
        public void Swim()
        {
            System.Console.WriteLine("Hybrid Bird can Swim");
        }

        /// <inheritdoc />
        public void Dance()
        {
            System.Console.WriteLine("Hybrid Bird can Dance");
        }

        /// <inheritdoc />
        public void Sing()
        {
            System.Console.WriteLine("Hybrid Bird can Sing");
        }

        /// <inheritdoc />
        void Bird1.Walk()
        {
            System.Console.WriteLine("Bird1 can Walk");
        }

        /// <inheritdoc />
        void Bird2.Walk()
        {
            System.Console.WriteLine("Bird2 can Walk");
        }
    }
    #endregion
}