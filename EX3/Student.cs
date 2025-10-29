namespace App;

public class Student
{
    public string FirstName { get; }
    public string LastName { get; }
    
    public Group? Group { get; internal set; }

    public Student(string firstName, string lastName)
    {
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
    }

    public override string ToString() => $"Студент(\"{FirstName} {LastName}\")";
}

