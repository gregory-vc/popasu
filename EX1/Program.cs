namespace App;

internal static class Program
{
    public static void Main()
    {
        Demo1();
        Demo2();
        Demo3();
        Demo4();
    }

    private static void Demo1()
    {
        Console.WriteLine("1) Ассоциация (однонаправленная)");
        var a1 = new A1();
        var b1 = new B1 {PropertyB = "test"};
        a1.SetAssociation(b1);
        Console.WriteLine(a1.B.PropertyB);
        Console.WriteLine();
    }

    private static void Demo2()
    {
        Console.WriteLine("2) Ассоциация (двунаправленная)");
        var a2 = new A2 {PropertyA = "test A"};
        var b2 = new B2 {PropertyB = "test B"};
        a2.SetAssociation(b2);
        Console.WriteLine(a2.B.PropertyB);
        Console.WriteLine(a2.B.A.PropertyA);
        Console.WriteLine();
    }
    
    private static void Demo3()
    {
        Console.WriteLine("3) Агрегация 1->1");
        var a = new A3();
        var b = new B3 { PropertyB = "B3 value" };
        a.Attach(b);
        Console.WriteLine(a.B.PropertyB);
        a.Dispose();
        Console.WriteLine(b.PropertyB);
        Console.WriteLine(b.Owner == null ? "да" : "нет");
        Console.WriteLine();
    }
    
    private static void Demo4()
    {
        Console.WriteLine("4) Композиция 1->1");
        B4 bRef;
        using (var a = new A4("B4 value"))
        {
            bRef = a.B;
            Console.WriteLine(a.B.PropertyB);
        }

        try
        {
            Console.WriteLine(bRef.PropertyB);
            Console.WriteLine("сюда не доходим");
        }
        catch (ObjectDisposedException)
        {
            Console.WriteLine("ObjectDisposedException, доступа нет");
        }
        Console.WriteLine();
    }
}