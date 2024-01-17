using System;

namespace Calculator
{
    public class Calculator
    {
        static Calculator() // static constructor
        {
            Console.WriteLine("\t\t\t\t\t\t\t╔═══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t║                    WELCOME TO MY CALCULATOR                   ║");
            Console.WriteLine("\t\t\t\t\t\t\t╚═══════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n");

        }
        public static void Main(string[] args)
        {
            string choice;
            bool cont = true;
            do
            {
                Console.WriteLine("\t\t\t\t\t\t\t\t\t     ******OPERATIONS*******\n");
                Console.WriteLine("\t\t\t\t\t\t\t+ : ADDITION");
                Console.WriteLine("\t\t\t\t\t\t\t- : SUBSTRACTION");
                Console.WriteLine("\t\t\t\t\t\t\t* : MULTIPLICATION");
                Console.WriteLine("\t\t\t\t\t\t\t/ : DIVISION");
                Console.WriteLine("\t\t\t\t\t\t\tE : EXPRESSION");
                Console.WriteLine("\t\t\t\t\t\t\tQ : QUIT");
                Console.WriteLine("\n");
                Console.Write("\t\t\t\t\t\t\tENTER YOUR CHOICE FROM ABOVE : ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "+":
                        Addition add = new Addition();
                        break;

                    case "-":
                        Substraction sub = new Substraction();
                        break;

                    case "*":
                        Multiplication multiplication = new Multiplication();
                        break;

                    case "/":
                        Division divide = new Division();
                        break;

                    case "E":
                        Expression exp = new Expression();
                        break;

                    case "Q":
                        cont = false;
                        break;

                    default:
                        Console.WriteLine("\t\t\t\t\t\t\tENTER A VALID CHOICE");
                        break;
                }
            }

            while (cont);

        }
    }
}