// using Question1;
// using Question2;
// using Question3;

// namespace main
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             #region Question1
//             // IList<Person> p = new List<Person>();

//             // p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
//             // p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
//             // p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
//             // p.Add(new Person { Name = "Jennifer", Address = "J1704", Age = 33 });

//             // PersonImplementation person = new();

//             // Console.WriteLine($"{person.GetName(p)} \n {person.Average(p)} \n{person.Max(p)}");
//             #endregion

//             #region Question2
//             // Source source=new();
//             // Console.WriteLine(source.Add(1,2,3));
//             // Console.WriteLine(source.Add(2.5,1.5,2.1));

//             #endregion

//             #region Question3

//             // var commodities = new List<Commidity>()
//             // {
//             //     new Commidity(CommodityCategory.Furniture, "Bed", 2, 50000),
//             //     new Commidity(CommodityCategory.Grocery, "Flour", 5, 80),
//             //     new Commidity(CommodityCategory.Service, "Insurance", 8, 8500)
//             // };

//             // var prepareBill = new PrepareBill();

//             // prepareBill.SetTaxRates(CommodityCategory.Furniture, 18);
//             // prepareBill.SetTaxRates(CommodityCategory.Grocery, 5);
//             // prepareBill.SetTaxRates(CommodityCategory.Service, 12);

//             // var billAmount = prepareBill.CalculateBillAmount(commodities);
//             // Console.WriteLine($"{billAmount}");

//             #endregion

//             #region Question4

//             #endregion
//         }
//     }
// }



namespace Practise
{
    public class Bike
    {
        public string Model {get;set;}
        public string Brand {get;set;}
        public int PricePerDay{get;set;}
    }

    public class BikeUtility
    {
         public void AddBikeDetails(string model, string brand, int pricePerDay)
        {
            int key= Program.bikeDetails.Count()+1;

            Bike bike=new Bike
            {
                Model=model,
                Brand=brand,
                PricePerDay=pricePerDay
            };
            Program.bikeDetails.Add(key,bike);
        }
        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            SortedDictionary<string, List<Bike>> groupedBikes =new();

            foreach (var item in Program.bikeDetails.Values)
            {
                if (!groupedBikes.ContainsKey(item.Brand))
                {
                    groupedBikes[item.Brand] = new List<Bike>();
                }
                groupedBikes[item.Brand].Add(item);
            }

            return groupedBikes;
        }
    }
    public class Program
    {
        public static SortedDictionary<int, Bike> bikeDetails=new();
        public static void Main()
        {
            while (true)
            {
                System.Console.WriteLine("1. Add Bike Detail\n2. Group Bikes By Brand\n3. Exit\n");
                System.Console.WriteLine("Enter your choice");
                int input=int.Parse(Console.ReadLine());

                BikeUtility bikeUtility=new();
                if (input == 1)
                {
                    System.Console.WriteLine("Enter the Model: ");
                    string modelname=Console.ReadLine();
                    Console.WriteLine("Enter the Brand: ");
                    string brandname=Console.ReadLine();
                    System.Console.WriteLine("Enter the Price per Day: ");
                    if(!int.TryParse(Console.ReadLine(),out int priceperday))
                    {
                        System.Console.WriteLine("Enter only integer input");
                        continue;
                    }
                    bikeUtility.AddBikeDetails(modelname,brandname,priceperday);
                    System.Console.WriteLine("Bike added SuccessFully\n");
                }
                if (input == 2)
                {
                    var groupedbikes=bikeUtility.GroupBikesByBrand();
                    foreach(var bikebrand in groupedbikes)
                    {
                        System.Console.WriteLine(bikebrand.Key);
                        foreach(var bike in bikebrand.Value)
                        {
                            System.Console.WriteLine(bike.Model);
                        }
                    }
                }
                if(input == 3)
                {
                    break;
                }
            }
        }
    }
}