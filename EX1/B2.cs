namespace App;

public class B2
{
    public string PropertyB { get; set; } = "";
    
    private A2? _a2;
    
    public A2 A => _a2  ?? throw new Exception("A2 не инициализрована");
    
    public void SetAssociation(A2 a)
    {
        if (_a2 != null) throw new InvalidOperationException("Связь уже установлена.");
        _a2 = a ?? throw new ArgumentNullException(nameof(a));
    }
}