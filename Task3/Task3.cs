using System.Net.WebSockets;

internal class Program
{
    interface ICar
    {
        string Driver { get; set; }
        string Model { get;}
        string Brakes();
        string Push();
    }

    class Ferrari : ICar
    {
        private string model = "488-Spider";
        private string driver;

        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Driver { get => driver; set => driver = value; }
        public string Model { get => model;}
        

        public string Brakes ()
        {
            return "Brakes!";
        }

        public string Push()
        {
            return "Zadu6avamsA!";
        }
    }

    static void Main()
    {
        string driver = Console.ReadLine();
        ICar car= new Ferrari(driver);
        Console.WriteLine(car.Model + "/" + car.Brakes() + "/" + car.Push() + "/" + car.Driver) ;
    }
}