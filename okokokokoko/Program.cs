Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Darova eta Класний журнал");
Console.WriteLine("\nMenu:");
Console.WriteLine("1. Add student");
Console.WriteLine("2. Edit student");
Console.WriteLine("3. Delete student");
Console.WriteLine("4. Add subject");
Console.WriteLine("5. Edit subject");
Console.WriteLine("6. Delete subject");
Console.WriteLine("7. Enter grade");
Console.WriteLine("8. Edit grade");
Console.WriteLine("9. Calculate GPA");
Console.WriteLine("10. Save data");
Console.WriteLine("11. Exit");

Student st = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter Student FirstName: ");
            st.FirstName = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            st.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Last name: ");
            st.LastName = Console.ReadLine();
            Console.Write("Enter Student Class: ");
            st.Class = Console.ReadLine();
           
            break;
        case 2:
            Console.WriteLine("------- Student ---------");
            Console.WriteLine($"Name: {st.FirstName}");
            Console.WriteLine($"Age: {st.Age}");
            Console.WriteLine($"Class: {st.Class}");
            break;
    }




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
