namespace Day9
{
    public partial class PartialClass
    {
        public PartialClass(int id,string name)
        {
            this.Id=id;
            this.Name=name;
        }

        public void GetDetails()
        {
            System.Console.WriteLine(this.Id);
            System.Console.WriteLine(this.Name);
        }
    }
}