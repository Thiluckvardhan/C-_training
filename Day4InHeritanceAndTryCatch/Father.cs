namespace Day4
{
    /// <summary>
    /// Explains the concept of virtual and override 
    /// </summary>
    
    #region Override example
    public class Father
    {
        public virtual string InterestOn()
        {
            return "I Like to play Cricket";
        }
    }
    public class Son : Father
    {
        public override string InterestOn()
        {
            return "Mobile Games";
        }
    }
    #endregion
}