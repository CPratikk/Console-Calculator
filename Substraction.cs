using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Substraction
{
    public Substraction()
    {
        Console.Write("\t\t\t\t\t\t\tEnter the first decimal number:");
        string input1 = Console.ReadLine();

        Console.Write("\t\t\t\t\t\t\tEnter the second decimal number:");
        string input2 = Console.ReadLine();

        if (decimal.TryParse(input1, out decimal number1) && decimal.TryParse(input2, out decimal number2))
        {
            decimal result = number1 - number2;
            Console.Write("\n\t\t\t\t\t\t\tResult : ");
            Console.WriteLine($"{number1} - {number2} = {result}");
        }
        else
        {
            Console.WriteLine("\t\t\t\t\t\t\tInvalid input. Please enter valid decimal numbers.");
        }
    }
}

