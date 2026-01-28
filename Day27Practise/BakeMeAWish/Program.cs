using System.Runtime.CompilerServices;

namespace BakeMeAWish
{

    public class CakeOrder
    {
        private static Dictionary<string,double> orderMap=new();
        
        public static void addOrderDetails(string orderid,double cakeCost)
        {
            orderMap.Add(orderid,cakeCost);
        }
        public static Dictionary<string,double> findOrdersAboveSpecifiedCost(double cakeCost)
        {
            Dictionary<string,double> result=new();
            foreach(var item in orderMap)
            {
                if (item.Value > cakeCost)
                {
                    result[item.Key] = item.Value;
                }
            }
            return result;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter number of cake orders to be added");
            if (!int.TryParse(Console.ReadLine(), out int ordercount))
            {
                return;
            }

            Console.WriteLine("Enter the cake order details (Order Id: CakeCost)");

            for (int i = 0; i < ordercount; i++)
            {
                string? orderdetails = Console.ReadLine();
                if (orderdetails == null)
                {
                    i--;
                    continue;
                }

                string[] orders = orderdetails.Split(':');
                if (orders.Length != 2)
                {
                    i--;
                    continue;
                }

                if (!double.TryParse(orders[1], out double cost))
                {
                    i--;
                    continue;
                }

                CakeOrder.addOrderDetails(orders[0], cost);
            }

            Console.WriteLine("Enter the cost to search the cake orders");
            if (!double.TryParse(Console.ReadLine(), out double searchCost))
            {
                return;
            }

            Dictionary<string, double> result =
                CakeOrder.findOrdersAboveSpecifiedCost(searchCost);

            if (result.Count == 0)
            {
                Console.WriteLine("No cake orders found");
                return;
            }

            Console.WriteLine("Cake Orders above the specified cost");
            foreach (var item in result)
            {
                Console.WriteLine($"Order ID: {item.Key}, Cake Cost: {item.Value}");
            }
        }
    }
}