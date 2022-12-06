using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

internal class Task1
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
    }
    public class Citizen : IPerson
    {
        private string name;
        private int age;
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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
    }
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        IPerson person = new Citizen(name, age);
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}





