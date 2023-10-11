namespace NumberAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name ");
            string name = Console.ReadLine();

            while (true) //start of loop
            {
                Console.WriteLine("Enter a number between 1 and 100");
            string numInput = Console.ReadLine();
            int num = int.Parse(numInput);


            if (num > 0 && num <101) //number validation
            {
                if (num % 2 == 1 && num < 60) //main conditionals
                {
                    Console.WriteLine($"{num} is odd and less than 60, {name}");
                }
                else if (num % 2 == 0 && num > 1 && num < 26)
                {
                    Console.WriteLine($"{num} is even and less than 25, {name}");
                }
                else if (num % 2 == 0 && num > 25 && num < 60)
                {
                    Console.WriteLine($"{num} is even and between 26 and 60 inclusive, {name}");
                }
                else if (num % 2 == 0 && num > 60)
                {
                    Console.WriteLine($"{num} is even and greater than 60, {name}");
                }
                else if (num % 2 == 1 && num > 60) 
                {
                    Console.WriteLine($"{num} is odd and greater than 60, {name}");
                }


            }
            else
            {
                Console.WriteLine("Invalid number"); //invalid number message
            }
                Console.WriteLine("Continue? yes/no"); //loop code

                string anwser = Console.ReadLine();
                if (anwser.Equals("yes"))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            







        }
    }
}