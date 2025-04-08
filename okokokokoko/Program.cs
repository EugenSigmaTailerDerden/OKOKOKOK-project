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

List<Student> students = new();
List<Subject> Subjects = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 11:
            Environment.Exit(0);
            break;

        case 1:
            Student st = new Student();
            Console.Write("Enter Student FirstName: ");
            st.FirstName = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            st.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Last name: ");
            st.LastName = Console.ReadLine();
            Console.Write("Enter Student Class: ");
            st.Class = Console.ReadLine();
            students.Add(st);
            break;

        case 2:
            if (students.Count == 0)
            {
                Console.WriteLine("No students available!");
                break;
            }
            Console.WriteLine("------- Students List ---------");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"[{i}] Name: {students[i].FirstName} {students[i].LastName}");
                Console.WriteLine($"   Age: {students[i].Age}");
                Console.WriteLine($"   Class: {students[i].Class}");
                Console.WriteLine("----------------------------");
            }
            break;

        case 3:
            if (students.Count == 0)
            {
                Console.WriteLine("No students to delete!");
                break;
            }
            for (int i = 0; i < students.Count; ++i)
                Console.WriteLine($"[{i}] Student: {students[i].FirstName} {students[i].LastName}");

            Console.Write("Enter number to delete: ");
            int numToDelete = Convert.ToInt32(Console.ReadLine());

            if (numToDelete < 0 || numToDelete >= students.Count)
            {
                Console.WriteLine("Number out of range!");
                break;
            }

            students.RemoveAt(numToDelete);
            Console.WriteLine("Student deleted successfully!");
            break;
    }
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
