using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Problems problems = new Problems();
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            problems.SearchForSubString("th", words);

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike", "Ian" };
            problems.RemoveDuplicates(names);

            List<string> classGrades = new List<string>()
                {
                    "80,100,92,89,65",
                    "93,81,78,84,69",
                    "73,88,83,99,64",
                    "98,100,66,74,55"
                };
            problems.CalculateGradeAverageOfAverageMinusLowest(classGrades);

            Console.ReadLine();
        }
    }
}

