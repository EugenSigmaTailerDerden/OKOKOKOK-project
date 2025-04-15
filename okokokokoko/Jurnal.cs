using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okokokokoko
{
    internal class jurnal
    {
        List<Student> students = new();
        public void Addstudent()
        {
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
        }
        public void Editstudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available!");
                return;
            }
            Console.WriteLine("------- Students List ---------");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"[{i}] Name: {students[i].FirstName} {students[i].LastName}");
                Console.WriteLine($"   Age: {students[i].Age}");
                Console.WriteLine($"   Class: {students[i].Class}");
                Console.WriteLine("----------------------------");
            }
        }
        public void Deletestudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students to delete!");
                return;
            }
            for (int i = 0; i < students.Count; ++i)
                Console.WriteLine($"[{i}] Student: {students[i].FirstName} {students[i].LastName}");

            Console.Write("Enter number to delete: ");
            int numToDelete = Convert.ToInt32(Console.ReadLine());

            if (numToDelete < 0 || numToDelete >= students.Count)
            {
                Console.WriteLine("Number out of range!");
                return;
            }

            students.RemoveAt(numToDelete);
            Console.WriteLine("Student deleted successfully!");
        }
    }   
}
    
    
    
    
