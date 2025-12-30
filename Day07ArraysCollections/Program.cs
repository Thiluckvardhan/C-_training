using Day7;

/// <summary>
/// this is the class from where all the calls happens
/// </summary>
public class Program
{

    #region Main method
    /// <summary>
    /// Main Method 
    /// </summary>

    public static void Main()
    {
        // Interface Example

        // HybridBird hb = new HybridBird();
        // Direct calls via concrete type demonstrate combined behaviors.
        // hb.Fly();
        // hb.Swim();
        // hb.Dance();
        // hb.Sing();

        // Bird1 b1 = new HybridBird();
        // Bird2 b2 = new HybridBird();

        // Explicit interface implementations are reachable only through the interface references.
        // b1.Walk();
        // b2.Walk();

        // question 1
        // PasswordGenerator pwg=new PasswordGenerator();
        // string result=string.Empty;
        // result=pwg.CleanseAndInvert("Aeroplane");
        // Console.WriteLine(result);
        // result=pwg.CleanseAndInvert("Cowages");
        // Console.WriteLine(result);
        // result=pwg.CleanseAndInvert("Magic");
        // Console.WriteLine(result);
        // result=pwg.CleanseAndInvert("Kinder World");
        // Console.WriteLine(result);
        // result=pwg.CleanseAndInvert("B@rbie");
        // Console.WriteLine(result);

        #region Jacked Array
        //  JackedArray Example
        // JackedArray jack = new JackedArray();
        // jack.Call();
        #endregion

        #region Collections
        Collections col = new();
        col.Sample1();
        #endregion
    }
    #endregion
}