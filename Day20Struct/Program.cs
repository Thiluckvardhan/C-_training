namespace Day20Struct;

public ref struct TempBuffer
{
    public void Dispose()
    {
        // cleanup logic (concept)
        System.Console.WriteLine("TempBuffer disposed");
    }
}

public static class BufferDemo
{
    public static void UseBuffer()
    {
        // C# 8.0: using works with ref struct (pattern-based)
        using var buf = new TempBuffer();
        System.Console.WriteLine("Using TempBuffer...");
        // work with buf
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BufferDemo.UseBuffer();
        System.Console.WriteLine("Done.");
    }
}