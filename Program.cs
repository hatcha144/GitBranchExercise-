using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int userInput = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your number is {0}", userInput);
            Console.ReadLine();
            DisplayNums.DisplayNum(userInput);
            Console.ReadKey();
        }
        
}
