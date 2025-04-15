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
           
            break;

        case 2:
           
            break;

        case 3:
           
            break;
    }
}
