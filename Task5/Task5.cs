using System.Reflection;
using static Task5;

internal class Task5
{
    interface ICitizens: IID
    {
        string Name { get; set; }
        int Age { get; set; }
    }

    interface IID
    {
        string ID { get; set; }
    }

    interface IRobots : IID
    {
        string model { get; set; }
    }

    public class Citizens : ICitizens
    {
        public Citizens(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id; 
        }

        public string Name { get;  set; }
        public int Age { get;  set; }
        public string ID { get;  set; }
    }

    public class Robots : IRobots
    {
        public Robots(string model, string id)
        {
            this.model = model;
            this.ID = id;
        }

        public string model { get; set; }
        public string ID { get; set; }
    }

    public static void AddPerson(ref List<Citizens> Citizens, ref List<Robots>Robots)
    {
        
        while (true)
        {
            var text = Console.ReadLine().Split();
            if (text[0] == "End" || text[0] == "END")
            {
                break;
            }
            try 
            {
                string a1 = text[0];
                string a2 = text[1];
                string a3 = text[2];
                Citizens temp = new Citizens(a1, int.Parse(a2), a3);
                Citizens.Add(temp);
            }
            catch (Exception)
            {
                string a1 = text[0];
                string a2 = text[1];
                Robots temp = new Robots(a1, a2);
                Robots.Add(temp);
            }

        }
    }

    static void Main()
    {
        List <Citizens> Citizen = new List<Citizens>();
        List <Robots> Robots = new List<Robots>();

        AddPerson(ref Citizen, ref Robots);

        string endPoint = Console.ReadLine();

        foreach (var item in Citizen)
        {
            int temp = 0;
            for (int i = 0; i != endPoint.Length; i++)
            {
                if (endPoint[i] != item.ID[item.ID.Length-endPoint.Length + i]) //у нас є ід яке шукаємо і ціле ід, ми віднімаємо від цілого ід ту частинку і ідемо покроково на +i
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine(item.ID);
            }
            
        }
        foreach (var item in Robots)
        {
            int temp = 0;
            for (int i = 0; i != endPoint.Length; i++)
            {
                if (endPoint[i] != item.ID[item.ID.Length - endPoint.Length + i])
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine(item.ID);
            }
            
        }
    }
}