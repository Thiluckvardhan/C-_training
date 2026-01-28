using Question1;
using Question2;
using Question3;

namespace main
{
    public class Program
    {
        public static void Main()
        {
            #region Question1
            // IList<Person> p = new List<Person>();

            // p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            // p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            // p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
            // p.Add(new Person { Name = "Jennifer", Address = "J1704", Age = 33 });

            // PersonImplementation person = new();

            // Console.WriteLine($"{person.GetName(p)} \n {person.Average(p)} \n{person.Max(p)}");
            #endregion

            #region Question2
            // Source source=new();
            // Console.WriteLine(source.Add(1,2,3));
            // Console.WriteLine(source.Add(2.5,1.5,2.1));

            #endregion

            #region Question3

            // var commodities = new List<Commidity>()
            // {
            //     new Commidity(CommodityCategory.Furniture, "Bed", 2, 50000),
            //     new Commidity(CommodityCategory.Grocery, "Flour", 5, 80),
            //     new Commidity(CommodityCategory.Service, "Insurance", 8, 8500)
            // };

            // var prepareBill = new PrepareBill();

            // prepareBill.SetTaxRates(CommodityCategory.Furniture, 18);
            // prepareBill.SetTaxRates(CommodityCategory.Grocery, 5);
            // prepareBill.SetTaxRates(CommodityCategory.Service, 12);

            // var billAmount = prepareBill.CalculateBillAmount(commodities);
            // Console.WriteLine($"{billAmount}");

            #endregion

            #region Question4

            #endregion
        }
    }
}

