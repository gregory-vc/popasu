using App;

// Часть 1: агрегация + глубокое клонирование
var groupAgg = new Group("Группа КЛ-501");

var a1 = new Student("Иван", "Иванов");
var a2 = new Student("Мария", "Петрова");
var a3 = new Student("Сергей", "Смирнов");

groupAgg.Add(a1);
groupAgg.Add(a2);
groupAgg.Add(a3);

var clone = groupAgg.DeepClone();

Console.WriteLine("Оригинал (агрегация):");
Console.WriteLine(groupAgg.ToString());
Console.WriteLine("Клон (глубокая копия):");
Console.WriteLine(clone.ToString());

// Часть 2: композиция через New()
var groupComp = new Group("Группа КЛ-502");
groupComp.New("Анна", "Кузнецова");
groupComp.New("Дмитрий", "Соколов");
groupComp.New("Ольга", "Ильина");

Console.WriteLine("Композиция (создание через New):");
Console.WriteLine(groupComp.ToString());
