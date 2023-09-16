namespace _06.StoreBoxes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Box> boxes = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arr = input.Split(' ');
                int serialNumber = int.Parse(arr[0]);
                string itemName = arr[1];
                int itemQuantity = int.Parse(arr[2]);
                double itemPrice = double.Parse(arr[3]);
                double priceForBox = itemQuantity * itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.PricePerBox = priceForBox;

                box.Item.Name = itemName;
                box.Item.Price = itemPrice;
                boxes.Add(box);
            }
            List<Box> sortedList = boxes.OrderBy(b => b.PricePerBox).ToList();
            sortedList.Reverse();
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList[i].SerialNumber);
                Console.WriteLine($"-- {sortedList[i].Item.Name} - ${sortedList[i].Item.Price:F2}: {sortedList[i].ItemQuantity}");
                Console.WriteLine($"-- ${sortedList[i].PricePerBox:F2}");
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        public double PricePerBox { get; set; }
    }
}