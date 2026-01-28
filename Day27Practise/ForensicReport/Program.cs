namespace ForensicReportApp
{
    public class ForensicReport
    {
        private static Dictionary<string, DateTime> reportMap = new();

        public static void addReportDetails(string reportingOfficerName, DateTime reportFiledDate)
        {
            reportMap[reportingOfficerName] = reportFiledDate;
        }

        public static List<string> getOfficersWhoFiledReportsOnDate(DateTime reportFiledDate)
        {
            List<string> result = new();

            foreach (var item in reportMap)
            {
                if (item.Value.Date == reportFiledDate.Date)
                {
                    result.Add(item.Key);
                }
            }

            return result;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter number of reports to be added");

            if (!int.TryParse(Console.ReadLine(), out int reportCount))
            {
                return;
            }

            Console.WriteLine("Enter the Forensic reports (Reporting Officer: Report Filed Date)");

            for (int i = 0; i < reportCount; i++)
            {
                string? input = Console.ReadLine();
                if (input == null)
                {
                    i--;
                    continue;
                }

                string[] details = input.Split(':');
                if (details.Length != 2)
                {
                    i--;
                    continue;
                }

                if (!DateTime.TryParse(details[1],out DateTime filedDate))
                {
                    i--;
                    continue;
                }

                ForensicReport.addReportDetails(details[0], filedDate);
            }

            Console.WriteLine("Enter the filed date to identify the reporting officers");

            if (!DateTime.TryParse(Console.ReadLine(),out DateTime searchDate))
            {
                return;
            }

            List<string> officers = ForensicReport.getOfficersWhoFiledReportsOnDate(searchDate);

            if (officers.Count == 0)
            {
                Console.WriteLine("No reporting officer filed the report");
                return;
            }

            Console.WriteLine($"Reports filed on the {searchDate:yyyy-MM-dd} are by");
            foreach (string officer in officers)
            {
                Console.WriteLine(officer);
            }
        }
    }
}


