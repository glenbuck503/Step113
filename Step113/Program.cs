using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step113
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please choose a number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose a number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Numbers newNumber = new Numbers();
            newNumber.Addition(firstNumber, secondNumber);
            Numbers newNumber1 = new Numbers();
            newNumber.Addition(firstNumber:firstNumber,SecondNumber:secondNumber);


            Console.ReadLine();


        }
    }
}
