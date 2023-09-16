using System.Reflection;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Catalog catalog = new Catalog();
            catalog.Cars = new List<Car>();
            catalog.Trucks = new List<Truck>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] elements = input.Split("/");
                string typeOfVihecle = elements[0];
                string brand = elements[1];
                string model = elements[2];
                if (typeOfVihecle == "Car")
                {
                    int HP = int.Parse(elements[3]);
                    Car car = new Car(brand, model, HP);
                    catalog.Cars.Add(car);
                }
                else
                {
                    int weight = int.Parse(elements[3]);
                    Truck truck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(truck);
                }
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HP}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, int Hp)
        {
            Brand = brand;
            Model = model;
            HP = Hp;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }
    public class Catalog
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Truck> Trucks { get; set; } = new List<Truck>();

    }
}