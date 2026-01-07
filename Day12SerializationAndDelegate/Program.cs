using System.Xml.Serialization;
using System.Text.Json;
using Day12;
namespace Day12
{

class Program
{
    static void Main()
    {
        #region Conversion of Data to XML Format representation
        // // 1️⃣ Create MULTIPLE Person objects
        // var people = new List<Person>
        // {
        //     new Person
        //     {
        //         Name = "Thiluck",
        //         Age = 20,
        //         // Marks = new int[] { 85, 90, 95 }   // Initializing the marks array
        //         Marks = new List<int> { 85, 90, 95 }
        //     },
        //     new Person
        //     {
        //         Name = "Divyansh",
        //         Age = 21,
        //         Marks = new List<int> { 88, 92, 91 }
        //     },
        //     new Person
        //     {
        //         Name = "Alex",
        //         Age = 22,
        //         Marks = new List<int> { 75, 80, 78 }
        //     }
        // };

        // // 2️⃣ Create an XmlSerializer that knows how to convert
        // //    a Person object into XML format
        // var serializer = new XmlSerializer(typeof(List<Person>));

        // // 3️⃣ Create a StringWriter — this acts like a text file in memory
        // using var sw = new StringWriter();

        // // 4️⃣ Serialize the object 'p' into XML
        // //    The XML text is written into the StringWriter
        // serializer.Serialize(sw, people);

        // // 5️⃣ Convert the written XML data into a normal C# string
        // string xml = sw.ToString();

        // // 6️⃣ Print the XML string to the console
        // Console.WriteLine(xml);


        // instead of StringWritter we can use Console.Out for sending the output directly to the console

        // serializer.Serialize(Console.Out,p);
        // Console.WriteLine();
        // Console.ReadLine(); 
        #endregion


        #region Conversion of Data to XML Format representation
        // var people1 = new List<Person>
        // {
        //     new Person
        //     {
        //         Name = "Thiluck",
        //         Age = 20,
        //         // Marks = new int[] { 85, 90, 95 }   // Initializing the marks array
        //         Marks = new List<int> { 85, 90, 95 }
        //     },
        //     new Person
        //     {
        //         Name = "Divyansh",
        //         Age = 21,
        //         Marks = new List<int> { 88, 92, 91 }
        //     },
        //     new Person
        //     {
        //         Name = "Alex",
        //         Age = 22,
        //         Marks = new List<int> { 75, 80, 78 }
        //     }
        // };

        // string jsonString = JsonSerializer.Serialize(people1);
        // Console.WriteLine(jsonString);
        // // Output: {"Name":"Red Apples","Stock":100,"DateAcquired":"2017-08-24T00:00:00"}

        // var options = new JsonSerializerOptions { WriteIndented = true };
        // string formattedJsonString = JsonSerializer.Serialize(people1, options);
        // Console.WriteLine(formattedJsonString);
        // Output:
        // {
        //   "Name": "Red Apples",
        //   "Stock": 100,
        //   "DateAcquired": "2017-08-24T00:00:00"
        // }
        #endregion

        #region Delegate

        Delegate d=new Delegate();
        d.Delegation();
        #endregion
    }
}

}