using App;

var group = new Group("Группа АГ-301");

var s1 = new Student("Иван", "Иванов");
var s2 = new Student("Мария", "Петрова");
var s3 = new Student("Сергей", "Смирнов");

group.Add(s1);
group.Add(s2);
group.Add(s3);

Console.WriteLine(group.ToString());
