using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Expression
{
    public Expression() 
    {
        Console.Write("\t\t\t\t\t\t\tEnter a mathematical expression: ");
        string expression = Console.ReadLine();

        // Create a DataTable to use its Compute method for expression evaluation
        DataTable table = new DataTable();
        table.Columns.Add("expression", typeof(double), expression);

        // Create a DataRow to compute the result
        DataRow row = table.NewRow();
        table.Rows.Add(row);

        // Get the result from the "expression" column of the DataRow
        double result = (double)row["expression"];

        Console.WriteLine("\t\t\t\t\t\t\tResult: " + result);
    }
}


