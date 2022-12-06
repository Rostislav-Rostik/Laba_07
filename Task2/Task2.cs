using System.Numerics;
using System.Reflection.Metadata.Ecma335;

internal class Task1
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    interface IIdentifable
    {
        string Id { get; set; }
    }

    interface IBirthable
    {
        string Birthdate { get; set; }
    }

    public class Citizen : IPerson, IIdentifable, IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
        public virtual string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public virtual int Age
        {
            get => age;
            set
            {
                age = value;
            }
        }

        public string Id
        { 
            get => id; 
            set 
            {
                id = value;
            }
        }
        public string Birthdate { get => birthdate; set => birthdate = value; }
    }

    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();
        IIdentifable identifable = new Citizen(name, age,id,birthdate);
        IBirthable ibirthable = new Citizen(name, age,id,birthdate);
        Console.WriteLine("\n");
        Console.WriteLine(identifable.Id);
        Console.WriteLine(ibirthable.Birthdate);
    }
}