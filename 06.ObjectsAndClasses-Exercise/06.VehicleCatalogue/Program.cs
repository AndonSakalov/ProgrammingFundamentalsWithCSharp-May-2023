namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleInfo = input.Split();
                string type = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int Hp = int.Parse(vehicleInfo[3]);
                Vehicle vehicle = new Vehicle(model, color, Hp, type);
                vehicles.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle foundVehicle = vehicles.Find(x => x.Model == input);

                if (foundVehicle != null)
                {
                    foundVehicle.Print(foundVehicle.Type, foundVehicle.Model, foundVehicle.Color, foundVehicle.HP);
                }
            }
            decimal carsHp = 0;
            decimal trucksHp = 0;
            int cars = 0;
            int trucks = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Type == "Car")
                {
                    carsHp += vehicle.HP;
                    cars++;
                }
                else
                {
                    trucksHp += vehicle.HP;
                    trucks++;
                }
            }
            if (cars > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsHp / cars:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (trucks > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksHp / trucks:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
    public class Vehicle
    {
        public Vehicle(string model, string color, int Hp, string type)
        {
            Model = model;
            Color = color;
            HP = Hp;
            Type = $"{type[0].ToString().ToUpper()}{type.Substring(1)}";
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HP { get; set; }
        public string Type { get; set; }

        public void Print(string type, string model, string color, int Hp)
        {
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Horsepower: {Hp}");
        }
    }
}