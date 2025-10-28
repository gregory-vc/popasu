namespace App;

public class A1
{
    private B1? _b1;
    public B1 B => _b1 ?? throw new Exception("B1 не инициализрована");

    public void SetAssociation(B1 b)
    {
        if (_b1 != null) throw new InvalidOperationException("Связь уже установлена.");
        _b1 = b ?? throw new ArgumentNullException(nameof(b));
    }
}