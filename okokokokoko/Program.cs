Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Darova eta Класний журнал");
Console.WriteLine("\nМеню:");
Console.WriteLine("1. Додати учня");
Console.WriteLine("2. Редагувати учня");
Console.WriteLine("3. Видалити учня");
Console.WriteLine("4. Додати предмет");
Console.WriteLine("5. Редагувати предмет");
Console.WriteLine("6. Видалити предмет");
Console.WriteLine("7. Внести оцінку");
Console.WriteLine("8. Редагувати оцінку");
Console.WriteLine("9. Обчислити середній бал");
Console.WriteLine("10. Зберегти дані");
Console.WriteLine("11. Вийти");
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
}

public class Subject
{
    public string Name { get; set; }
    public string Teacher { get; set; }
    public string Room { get; set; } 
    public string Textbook { get; set; }
}
