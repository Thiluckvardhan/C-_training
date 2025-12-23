using System.Xml.Serialization;

namespace Day1
{
    class Feettocenti
{
    public static void feet()
    {
        String? input=Console.ReadLine();
        if(double.TryParse(input,out double centi))
        {
            centi=centi*(30.48);
        }
        Console.Write(centi);
    }
}
}