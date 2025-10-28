namespace App;

public class A4: IDisposable
{
    public B4 B { get; }

    public A4(string valueForB) => B = new B4(valueForB);

    public void Dispose()
    {
        B.Dispose(); 
    }
}