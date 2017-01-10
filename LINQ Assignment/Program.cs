using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Function theFunctions = new Function();
            theFunctions.NoDuplicates();
            theFunctions.AveragingFunction();
            theFunctions.LetterFrequency();
            Console.ReadKey();
        }
    }
}