using System.Collections.Generic;
namespace Day9

{
    public class Student
    {
        public int RollNo{get;set;}
        public string Name{get;set;}
        private string Address;
        
        private List<string> Books=new List<string>();

        public string this[int index]
        {
            get
            {
                if (index >= Books.Count)
                {
                    return "Index is not Correct.";
                }
                return Books[index];
            }
            set
            {
                if (index < Books.Count)
                {
                    Books[index]=value;
                }
                Books.Add(value);
            }
        }
        public Student(int rollno,string name,string address)
        {
            this.RollNo=rollno;
            this.Name=name;
            this.Address=address;
        }
    }
}