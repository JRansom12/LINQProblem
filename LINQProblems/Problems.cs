using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problems
    {
        public void SearchForSubString(string search, List<string> words)
        {
            var thwords = words.Where(w => w.Contains(search));
            foreach (var word in thwords)
            {
                Console.WriteLine(word);
            }
        }
        public void RemoveDuplicates(List<string> names)
        {
            var namesOnce = names.Distinct();
            foreach (var name in namesOnce)
            {
                Console.WriteLine(name);
            }
        }
    }
}
