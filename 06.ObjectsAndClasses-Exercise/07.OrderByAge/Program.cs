namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> people = new List<Person>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input.Split();
                string name = personInfo[0];
                string ID = personInfo[1];
                int age = int.Parse(personInfo[2]);
                Person alreadyExistingPerson = people.Find(p => p.Id == ID);
                if (alreadyExistingPerson != null)
                {
                    int index = people.IndexOf(alreadyExistingPerson);
                    people[index].Age = age;
                    people[index].Name = name;
                }
                else
                {
                    Person person = new Person(name, ID, age);
                    people.Add(person);
                }
            }
            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
    public class Person
    {
        public Person(string name, string id, int age) 
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}