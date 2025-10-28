namespace App;

public class B4: IDisposable
{
    private readonly string _value;
    private bool _disposed;

    internal B4(string value) => _value = value;

    public string PropertyB
    {
        get
        {
            if (_disposed) throw new ObjectDisposedException(nameof(B4));
            return _value;
        }
    }

    public void Dispose() => _disposed = true;
}