using System.Formats.Asn1;

namespace Day17
{
    public class AsyncAwaitExample
    {
        public async Task AsyncMethod()
        {
            Console.WriteLine("Task Started");
            await Task.Delay(3000); //Non-blocking delay
            Console.WriteLine("Task Completed after 3 Seconds");
        }

        public async Task CallMethod()
        {
            string result = await FetchDataAsync("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(result);
            await AsyncMethod();
        }

        public async Task<string> FetchDataAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                return response;
            }
        }
    }
}