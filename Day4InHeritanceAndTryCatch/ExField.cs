namespace Day4
{
    public class ExField
    {
        private int id;
        
        public int Id
        {
            set
            {
                if(value>0)id=value;
                else
                {
                    id=0;
                    throw new InvalidOperationException("Id must be greater than 0");
                }
            }
        }
        public string DisplayEmpDetails()
        {
            return $"Employee Id is {id}";
        }
    }
}