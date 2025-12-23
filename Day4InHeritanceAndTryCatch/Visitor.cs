using System;

namespace Day4
{
    public class Visitor
    {
        public int Id {get;set;}
        public string Name{get;set;}
        public string Requirement{get;set;}
        public string logHistroy{get;set;}
        
        public  Visitor()
        {
            logHistroy=$"Object created on {DateTime.Now.ToString()} \n";
        }

        public Visitor(int id):this()
        {
            this.Id=id;
            logHistroy=$"Id created on {DateTime.Now.ToString()} \n";
        }
        public Visitor(int id,string name):this(id)
        {
            if(name.ToLower().Contains("idiot"))
            {
                throw new ArgumentException("Name contains inappropriate content.");
            }
            logHistroy=$"Name created on {DateTime.Now.ToString()} \n";
            this.Name=name;
        }
        public Visitor(int id,string name,string requirement):this(id,name)
        {
            this.Requirement=requirement;
            logHistroy=$"Requirement created on {DateTime.Now.ToString()} \n";
        }
    }
}