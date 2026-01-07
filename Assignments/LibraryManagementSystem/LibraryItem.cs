namespace Libraryitem
{
    public abstract class LibraryItem
    {
        public string? Title { get; set; }
        public string? Auther { get; set; }
        public int ItemId;

        public LibraryItem(string title, string auther, int id)
        {
            this.Title = title;
            this.Auther = auther;
            this.ItemId = id;
        }
        public abstract void DisplayItem();
        public abstract void CalcLateFee(int days);
    }

}