using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Division
{
    public Division()
    {
        Console.Write("\t\t\t\t\t\t\tEnter the first decimal number:");
        string input1 = Console.ReadLine();

        Console.Write("\t\t\t\t\t\t\tEnter the second decimal number:");
        string input2 = Console.ReadLine();

        if (decimal.TryParse(input1, out decimal number1) && decimal.TryParse(input2, out decimal number2))
        {
            try
            {
                decimal result = number1 / number2;
                Console.Write("\n\t\t\t\t\t\t\tResult : ");
                Console.WriteLine($"{number1} / {number2} = {result}");
            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine("\t\t\t\t\t\t\tCan't Divide a number by zero(0) !");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid decimal numbers.");
        }
    }
}


