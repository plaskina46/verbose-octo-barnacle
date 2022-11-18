class client
    {
        public static int count = 0;
        public string name;
        public int age;
        public object mobile;

        public client()
        {
            name = " Ann ";
            age = 22;
            mobile = 89963138090;

            count++;
            Print();

        }
        public client(string _name, int _age, object _mobile)
        {
            name = _name;
            age = _age;
            mobile = _mobile;

            count++;
            Print();

        }
        public void Print()
        {
            Console.WriteLine(" Name " + name);
            Console.WriteLine(" Age " + age);
            Console.WriteLine(" mobile " + mobile);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            client fitness = new client();
            Console.WriteLine();
            client sport = new client(" Ann ", 22, 89963138090);


          

            Console.ReadKey();
        }
    }
