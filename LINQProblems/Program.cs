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

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike", };
            problems.RemoveDuplicates(names);

            Console.ReadLine();
        }
    }
}

