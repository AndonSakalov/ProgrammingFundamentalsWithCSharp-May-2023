namespace _04.Students
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
                
                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;
                
                students.Add(student);
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
    }
}