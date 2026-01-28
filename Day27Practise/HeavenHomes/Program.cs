namespace HeavenHomes
{
    public class Apartment
    {
        private static Dictionary<string, double> apartmentDetailsMap = new();

        public static void addApartmentDetails(string apartmentNumber, double rent)
        {
            apartmentDetailsMap[apartmentNumber] = rent;
        }
        public static double findTotalRentofApartmentsInTheGivenRange(double minimumRent, double maximumRent)
        {
            double result = 0;
            foreach (var item in apartmentDetailsMap)
            {
                if (minimumRent <= item.Value && item.Value <= maximumRent)
                {
                    result += item.Value;
                }
            }
            return result;
        }
    }

    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Enter number of details to be added: ");
            if (!int.TryParse(Console.ReadLine(), out int apartmentCount))
            {
                System.Console.WriteLine("Enter only Integers as Input");
                return;
            }
            System.Console.WriteLine("Enter the details(Apartment Number:Rent)");
            for (int i = 1; i <= apartmentCount; i++)
            {
                string input = Console.ReadLine();
                string[] strings = input.Split(':');
                if (strings.Length != 2)
                {
                    System.Console.WriteLine("Invalid Input Try Again");
                    i--;
                    continue;
                }
                if (!double.TryParse(strings[1], out double rent))
                {
                    System.Console.WriteLine("Enter only Numbers in Rent");
                    i--;
                    continue;
                }
                Apartment.addApartmentDetails(strings[0], rent);
            }
            System.Console.WriteLine("Enter the range to filter the details: ");
            if (!double.TryParse(Console.ReadLine(), out double rentrange1))
            {
                System.Console.WriteLine("Enter only numbers in Range");
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out double rentrange2))
            {
                System.Console.WriteLine("Enter only numbers in Range");
                return;
            }
            if (rentrange1 > rentrange2)
            {
                (rentrange1, rentrange2) = (rentrange2, rentrange1);
            }
            System.Console.WriteLine($"Total Rent in the Range {rentrange1} to {rentrange2} USD:{Apartment.findTotalRentofApartmentsInTheGivenRange(rentrange1, rentrange2)}");
        }
    }
}