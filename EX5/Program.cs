using App;

var group = new Group("Группа КОМ-401");

group.New("Иван", "Иванов");
group.New("Мария", "Петрова");
group.New("Сергей", "Смирнов");

Console.WriteLine(group.ToString());
