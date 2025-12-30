namespace Day9
{
    public class MyData
    {
        private string[] arr = new string[10];

        public string this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
}