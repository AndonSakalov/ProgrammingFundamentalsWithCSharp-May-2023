namespace _05.Courses
{
    public class Course
    {
        public Course(string name, string student)
        {
            Name = name;
            Students = new List<string>();
            Students.Add(student);
        }
        public string Name { get; set; }
        public List<string> Students { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, Course>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] courseInfo = input.Split(" : ");
                string courseName = courseInfo[0];
                string studentName = courseInfo[1];
                Course newCourse = new Course(courseName, studentName);
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, newCourse);
                }
                else 
                {
                    courses[courseName].Students.Add(studentName);
                }
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Students.Count}");
                for (int i = 0; i < course.Value.Students.Count; i++)
                {
                    Console.WriteLine($"-- {course.Value.Students[i]}");
                }
            }
        }
    }
}