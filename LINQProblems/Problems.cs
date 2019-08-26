using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Problems
    {
        public IEnumerable<string> SearchForSubString(string search, List<string> words)
        {
            var thwords = words.Where(w => w.Contains(search));
            foreach (var word in thwords)
            {
                Console.WriteLine(word);
            }
            return thwords;
        }
        public IEnumerable<string> RemoveDuplicates(List<string> names)
        {
            List<string> namesList = names.Distinct().ToList();
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }
            return namesList;
        }
        public double CalculateGradeAverageOfAverageMinusLowest(List<string> classGrades)
        {
            var gradesListTwo = new List<double>();
            double totalGrades = 0;
            for (int i = 0; i < classGrades.Count; i++)
            {
                var numbers = classGrades[i].Split(',').Select(double.Parse).ToList();
                gradesListTwo = numbers.OrderByDescending(g => g).Take(numbers.Count() - 1).ToList();
                var listNumbers = gradesListTwo.Average();
                totalGrades += listNumbers;
            }
            double aveAve = totalGrades / classGrades.Count;
            return aveAve;
        }
    }
}
