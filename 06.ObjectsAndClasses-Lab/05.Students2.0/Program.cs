namespace _05.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Student> students = new List<Student>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split(" ").ToArray();
                string firstName = data[0];
                string lastName = data[1];
                string age = data[2];
                string homeTown = data[3];

                if (Student.IsStudentExisting(students, firstName, lastName))
                {
                    for (int i = 0; i < students.Count; i++)
                    {
                        if (students[i].FirstName == firstName && students[i].LastName == lastName)
                        {
                            students[i].Age = age;
                            students[i].HomeTown = homeTown;
                            break;
                        }
                    }
                }
                else
                {
                    Student student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;

                    students.Add(student);

                }

            }
            string cityName = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].HomeTown == cityName)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
                }
            }
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }

        public static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName)
                {
                    if (student.LastName == lastName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}