using System.Text;

namespace App;

public class Group
{
    public string Name { get; }

    private readonly List<Student> _students = new();
    public IReadOnlyList<Student> Students => _students;

    public Group(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public void Add(Student student)
    {
        if (student is null) throw new ArgumentNullException(nameof(student));
        if (!_students.Contains(student))
            _students.Add(student);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Группа: \"{Name}\"");
        sb.AppendLine($"Студентов: {Students.Count}");
        for (int i = 0; i < _students.Count; i++)
        {
            sb.AppendLine($"  {i + 1}. {_students[i]}");
        }
        return sb.ToString();
    }
}

