namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < studentsCount; i++)
            {
                string studentsInfo = Console.ReadLine();
                string[] elements = studentsInfo.Split();
                string firstName = elements[0];
                string lastName = elements[1];
                decimal grade = decimal.Parse(elements[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            students = students.OrderByDescending(students => students.Grade).ToList();
            for (int i = 0; i < studentsCount; i++)
            {
                Console.WriteLine($"{students[i].FirstName} {students[i].LastName}: {students[i].Grade:F2}");
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }
    }
}