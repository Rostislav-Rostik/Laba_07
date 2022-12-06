using System.Globalization;
using System.Net;
using System.Reflection;
using static Task6;

internal class Task6
{
    interface ICitizens : IID, IBirthday
    {
        string Name { get; set; }
        int Age { get; set; }
    }

    interface IPets : IBirthday
    {
        string Name { get; set; }
    }

    interface IBirthday
    {
        string Date { get; set; }
    }

    interface IID
    {
        string ID { get; set; }
    }

    interface IRobots : IID
    {
        string model { get; set; }

    }

    public class Pets : IPets
    {
        public Pets(string name, string date)
        {
            this.Name = name;
            this.Date = date;
        }

        public string Name { get; set; }
        public string Date { get; set; }
    }

    public class Citizens : ICitizens
    {
        public Citizens(string name, int age, string id, string date)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
            this.Date = date;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public string Date { get; set; }
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



    static void Main()
    {
        List<Citizens> Citizen = new List<Citizens>();
        List<Robots> Robots = new List<Robots>();
        List<Pets> Pets = new List<Pets>();
        while (true)
        {
            var smth = Console.ReadLine().Split();
            if (smth[0] == "End" || smth[0] == "END")
            {
                break;
            }
            if (smth[0] == "Citizen")
            {
                string a1 = smth[1];
                string a2 = smth[2];
                string a3 = smth[3];
                string a4 = smth[4];
                Citizens temp = new Citizens(a1, int.Parse(a2), a3, a4);
                Citizen.Add(temp);
            }
            else if (smth[0] == "Robot")
            {
                string a1 = smth[1];
                string a2 = smth[2];
                Robots temp = new Robots(a1, a2);
                Robots.Add(temp);

            }
            else if (smth[0] == "Pet")
            {
                string a1 = smth[1];
                string a2 = smth[2];
                Pets temp = new Pets (a1, a2);
                Pets.Add(temp);
            }
        }

        string endPoint = Console.ReadLine();

        foreach (var item in Citizen)
        {
            int temp = 0;
            for (int i = 0; i != endPoint.Length; i++)
            {
                if (endPoint[i] != item.Date[item.Date.Length - endPoint.Length + i])
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine(item.Date);
            }
        }
        foreach (var item in Pets)
        {
            int temp = 0;
            for (int i = 0; i != endPoint.Length; i++)
            {
                if (endPoint[i] != item.Date[item.Date.Length - endPoint.Length + i])
                {
                    temp++;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine(item.Date);
            }
        }
        
    }
}