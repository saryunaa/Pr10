using Slassascas;

namespace TransportApp
{
    abstract class Transport
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public bool IsRented { get; set; }

        public abstract string Type { get; }
        public abstract string LicenseCategory { get; }
        public abstract int Wheels { get; }
        public abstract bool HasMotor { get; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type}| model: {Model}| Color: {Color}| Max Speed: {Speed}| Does this have motor?: {(HasMotor ? "Yes" : "No")}| What LicenseCategory does you need to have: {(LicenseCategory)}| How many wheels does this vehicle have? {(Wheels + " wheels")}| Rented: {(IsRented ? "Yes" : "No")}|");
        }
    }
    class Program
    {
        static void Main()
        {
            List<Transport> transports = new List<Transport>
            {
                new Boat { Model = "THE SEGUE 76", Color = "Oak Wood and White Gold", Speed = 10, IsRented = false },
                new Car { Model = "Mercedes-Benz S-class 2020", Color = "Deep Purple", Speed = 220, IsRented = true },
                new Bicycle { Model = "Grail CF SL 7", Color = "Biege", Speed = 12, IsRented = false },
                new Motorcycle { Model = "Harley-Davidson Sportster S", Color = "Black", Speed = 160, IsRented = false },
                new Scooter { Model = "Vespa", Color = "Purple", Speed = 36, IsRented = true }
            };

            Console.WriteLine("List of all transport:");
            foreach (var transport in transports)
            {
                transport.DisplayInfo();
            }

            Console.WriteLine("\nEnter the type of transport (Boat, Car, Bicycle, Motorcycle, Scooter) to check if it is rented:");
            string input = Console.ReadLine();

            foreach (var transport in transports)
            {
                if (string.Equals(input, transport.Type, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Is the {transport.Type} rented? {(transport.IsRented ? "Yes" : "No")}");
                    break;
                }
            }
        }
    }
}