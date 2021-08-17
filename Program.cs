using System;
using System.Collections.Generic;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> employeeIDs = new Dictionary<int, string>();
            employeeIDs[0001] = "Nicko";
            employeeIDs[0002] = "Joel";

            Console.Write("What is employee ID: ");
            string idNumberIDText = Console.ReadLine();

            bool isValidIDNumber = int.TryParse(idNumberIDText, out int IDNumber);

            if (isValidIDNumber)
            {
                try
                {
                    Console.WriteLine(employeeIDs[IDNumber]);
                }
                catch
                {
                    Console.WriteLine("You're not an employee");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}
