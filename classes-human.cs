 public class Human
    {

        public string EducationLevel;
        public int Age;
        public bool IsAlive;
        public int MaxRunningSpeed;
        private string Sexuality;

        public Human()
        {
            //DEFAULT VALUES;
            Age = 15;
            IsAlive = true;
            EducationLevel = "High School";
            Sexuality = "Yes Please";
            MaxRunningSpeed = 8;
        }



        public bool Run(int howfast)
        {
            Console.WriteLine($"You asked to go {howfast} mph.");
            if (howfast < MaxRunningSpeed)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {

            Human cason = new Human();
            Human justin = new Human();
            justin.MaxRunningSpeed = 20;

            cason.Age = 27;
            cason.EducationLevel = "Yes, pleaase";
            cason.IsAlive = true;

            bool wasAbleToRun = cason.Run(12);

            if (wasAbleToRun)
            {
                Console.WriteLine("Yeah, go Cason!!");
            }
            else
            {
                Console.WriteLine("You can't run, Cason!!");
            }

            wasAbleToRun = justin.Run(12);

            if (wasAbleToRun)
            {
                Console.WriteLine("Yeah, go Justin!!");
            }
            else
            {
                Console.WriteLine("You can't run, Jusin!!");
            }

            Console.WriteLine($"Age = {cason.Age}, IsAlive = {cason.IsAlive}");





        }
    }
