using System.Text;

namespace App;

// На базе агрегации (EX4) с поддержкой глубокого клонирования
public class Group
{
    public string Name { get; }

    private readonly List<Student> _students = new();
    public IReadOnlyList<Student> Students => _students;

    public Group(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    // Агрегация: добавление ссылки на существующего студента
    public void Add(Student student)
    {
        if (student is null) throw new ArgumentNullException(nameof(student));
        if (!_students.Contains(student))
            _students.Add(student);
    }

    // Композиция: создание зависимого объекта внутри корня
    public Student New(string firstName, string lastName)
    {
        var student = new Student(firstName, lastName);
        _students.Add(student);
        return student;
    }

    // Глубокое клонирование корня и всех его зависимых объектов
    public Group DeepClone()
    {
        var clone = new Group(Name);
        foreach (var s in _students)
        {
            clone._students.Add(new Student(s.FirstName, s.LastName));
        }
        return clone;
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

