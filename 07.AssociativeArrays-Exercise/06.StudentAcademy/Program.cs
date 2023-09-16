namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            var studentsGradesMap = new Dictionary<string, decimal>();
            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                decimal studentGrade = decimal.Parse(Console.ReadLine());
                if (!studentsGradesMap.ContainsKey(studentName))
                {
                    studentsGradesMap.Add(studentName, studentGrade);
                }
                else 
                {
                    studentsGradesMap[studentName] = (studentGrade + studentsGradesMap[studentName]) / 2;
                }
            }
            foreach (var student in studentsGradesMap.Where(g => g.Value >= 4.5m))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}