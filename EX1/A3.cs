namespace App;

public class A3 : IDisposable
{
    private B3? _b3;
    public B3 B => _b3  ?? throw new Exception("B3 не инициализрована");
    
    public void Attach(B3 b)
    {
        if (b is null) throw new ArgumentNullException(nameof(b));
        if (_b3 != null) throw new InvalidOperationException("У A3 уже есть часть.");
        if (b.Owner != null) throw new InvalidOperationException("B3 уже присоединён к другому A3.");
        _b3 = b;
        b.Owner = this;
    }

    public B3 Detach()
    {
        var b = _b3 ?? throw new InvalidOperationException("Нечего отсоединять.");
        _b3 = null;
        b.Owner = null;
        return b;
    }
    
    public void Dispose()
    {
        if (_b3 != null)
        {
            _b3.Owner = null; 
            _b3 = null;
        }
    }
}