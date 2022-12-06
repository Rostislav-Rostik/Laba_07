internal class Task4
{
    interface ICall
    {
        string Call { get; set; }

        string Calling();
    }

    interface IBrowse
    {
        string Browse { get; set; }
        string Browsing();
    }

    class Phone : ICall, IBrowse
    {
        private string call;
        private string browse;

        public Phone(string call, string browse)
        {
            Call = call;
            Browse = browse;
        }

        public string Call
        {
            get => call;
            set
            {
                call = value;
            }
        }
        public string Browse
        {
            get => browse;
            set
            {
                browse = value;
            }
        }

        public string Calling()
        {

            return "Calling..." + call;
        }

        public string Browsing()
        {
            return "Browsing... " + browse;
        }
    }

    static void Main()
    {
        string call = Console.ReadLine();
        string browse = Console.ReadLine();

        string[] calling = call.Split(' ');
        string[] browsing = browse.Split(' ');

        ICall icall = new Phone(call, browse);
        IBrowse ibrowse = new Phone(call, browse);

        foreach (var word in calling)
        {
            Console.WriteLine("Calling..." + word);
        }

        foreach (var space in browsing)
        {
            Console.WriteLine("Browsing..." + space);
        }
    }
}