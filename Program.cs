using System;

namespace w02
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Welcome to Doctor's advice");
            var name = "";
            var age = 0;
            var issue = "";
            var visit = "";
            var temp = 0.0;
            var feedback = 'n';
            var rate = 0.0m;
            var visit_before = false;
            while (name == "")
            {

                Console.WriteLine("Enter your name");
                name = Console.ReadLine();

            }

            Console.WriteLine($"Hi {name} ");

            while (age == 0)
            {

                Console.WriteLine("Enter your age");
                age = Convert.ToInt32(Console.ReadLine());

            }

            if (age <= 5)
            {
                Console.WriteLine("You need to consult doctor directly!!");

            }

            if (age > 5)
            {
                Console.WriteLine("What is the health issue you are suffering with?");
                issue = Console.ReadLine();
                switch (issue)
                {
                    case "fever":
                        Console.WriteLine("You need to take paracetomol tablets twice a day!");
                        break;
                    case "cough":
                        Console.WriteLine("You need to take paracetomol tablets twice a day!");
                        break;
                    case "cold":
                        Console.WriteLine("You need to take crocin tablets twice a day!");
                        break;
                  default:
                        Console.WriteLine("You need to take advil tablets twice a day!");
                        break;
                }
                Console.WriteLine("What is your body present temperature?");
                temp = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("You need to take total of 6 tablets in  three days after your meal!");
            }
            Console.WriteLine("Was Doctor's Advice useful? y/n");
            feedback = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("How would you like to rate us?");
            rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Have you used this app before? yes/no");
            visit = Console.ReadLine();
            if(visit=="yes")
            {
                visit_before = true;
            }
            
            Console.WriteLine("Thank you!");
        }
    }
}

