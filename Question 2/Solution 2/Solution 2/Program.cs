using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine(); // user input 
            string B = Console.ReadLine(); // user input 
            Console.WriteLine(SimilarityCalculator.calculate(A)); // output
            Console.WriteLine(SimilarityCalculator.calculate(B)); // output
            Console.ReadKey(); // console read
        }
    }
}
