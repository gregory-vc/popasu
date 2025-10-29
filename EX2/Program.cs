using App;

var group = new Group("Группа ПИ-101");

group.AddStudent(new Student("Иван", "Иванов"));
group.AddStudent(new Student("Мария", "Петрова"));
group.AddStudent(new Student("Сергей", "Смирнов"));
group.AddStudent(new Student("Анна", "Кузнецова"));
group.AddStudent(new Student("Дмитрий", "Соколов"));

Console.WriteLine(group.ToString());
