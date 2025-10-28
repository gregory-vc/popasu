namespace App;

public class A2
{
    public string PropertyA { get; set; } = "";
    
    private B2? _b2;
    
    public B2 B => _b2  ?? throw new Exception("B2 не инициализрована");
    
    public void SetAssociation(B2 b)
    {
        if (_b2 != null) throw new InvalidOperationException("Связь уже установлена.");
        _b2 = b ?? throw new ArgumentNullException(nameof(b));
        _b2.SetAssociation(this);
    }
}