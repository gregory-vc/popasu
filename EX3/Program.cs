using App;

var group = new Group("Группа ПИ-201");

var s1 = new Student("Иван", "Иванов");
var s2 = new Student("Мария", "Петрова");
var s3 = new Student("Сергей", "Смирнов");

group.AddStudent(s1);
group.AddStudent(s2);
group.AddStudent(s3);

Console.WriteLine("Вывод группы через Group.ToString():");
Console.WriteLine(group.ToString());

Console.WriteLine("Вывод группы через обратную ссылку из объекта студента:");
Console.WriteLine(s2.Group?.ToString());
