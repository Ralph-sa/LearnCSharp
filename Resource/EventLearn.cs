using System;
public class Learn
{
    public delegate void Display(string msg);
    public Action<string> Display2;
    public void Show(string msg)
    {
        Console.WriteLine(msg);
    }
}

//delegate 创建特定委托
public class ComPare1
{
    public delegate int Comparison<in T>(T left, T right);

    public Comparison<int> comparator1;
    public Comparison<string> comparator2;


    public int comp1(int left, int right)
    {
        Console.WriteLine("comp1");
        return left > right ? left : right;
    }
    public int comp3(int left, int right)
    {
        Console.WriteLine("comp3");
        return left > right ? left : right;
    }
    public int comp4(int left, int right)
    {
        Console.WriteLine("comp4");
        return left > right ? left : right;
    }

    public int comp2(string left, string right)
    {
        Console.WriteLine("comp2");
        return left.Length > right.Length ? left.Length : right.Length;
    }
    public void Log()
    {
        Console.Write("aaaa");
    }
    public void Run()
    {
        comparator1 = comp1;
        comparator1 += comp3;
        comparator1 += comp4;
        //  comparator2 = comp2;
        comparator1(1, 2);
        Console.WriteLine("________________");
        comparator1 -= comp1;
        comparator1 -= comp3;
        //  comparator1(1, 2);
        comparator1.Invoke(1, 2);
        // int result2 = comparator2("111", "1111111");
        //  Console.WriteLine(result1);
        // Console.WriteLine(result2);
    }
}



public enum Severity
{
    Verbose,
    Trace,
    Information,
    Warning,
    Error,
    Critical
}
public static class Logger
{
    public static Action<string> WriteMessage;
    public static Severity LogLevel { get; set; } = Severity.Warning;
    public static void LogMessage(Severity s, string component, string msg)
    {
        if (s < LogLevel)
        {
            return;
        }
        var outputMsg = $"{2017}\t{s}\t{component}\t{msg}";
        WriteMessage?.Invoke(outputMsg);
    }
}
public class Test1
{
    public static void LogToMessage(string msg)
    {
        Console.Error.WriteLine(msg);
    }
}