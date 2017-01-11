using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Assignment
{
    class Function
    {
        public void NoDuplicates()
        {
            List<string> animalList = new List<string>();
            animalList.Add("cat");
            animalList.Add("snake");
            animalList.Add("dog");
            animalList.Add("snake");
            IEnumerable<string> Unique = animalList.Distinct();
            foreach (string item in Unique)
            {
                Console.WriteLine(item);
            }
        }
        public void AveragingFunction()
        {
            List<double> studentScore = new List<double>();
            List<string> studentGrades = new List<string>();
            studentGrades.Add("97,92,86,60");
            studentGrades.Add("96,80,91,57");
            studentGrades.Add("99,88,82,74");
            studentGrades.Add("75,84,31,89");
            foreach (var grade in studentGrades)
            {
                List<int> averagingList = new List<int>();
                string[] comma = grade.Split(',');
                foreach (string number in comma)
                {
                    var actualNumber = int.Parse(number);
                    averagingList.Add(actualNumber);
                }
                var lowGrade = (from x in averagingList select x).Min();
                averagingList.Remove(lowGrade);

                var NewAverage = Math.Round(averagingList.Average(), 1);

                Console.WriteLine("Student Average Grade:{0}", NewAverage);
                studentScore.Add(NewAverage);
                var averageClassGrade = Math.Round(studentScore.Average(), 1);
                Console.WriteLine("Class Average Grade:{0}", averageClassGrade);
            }
        }
        public void LetterFrequency()
        {
            List <string> wordChosen = new List<string>();
            Console.WriteLine("Enter word");
            var chosenWord = Console.ReadLine().ToUpper();
            foreach (char letter in chosenWord)
            {
                wordChosen.Add(letter.ToString());
                wordChosen.Sort();
            }
            var wordQuery = wordChosen.GroupBy(x => x[0]);
            foreach (var letter in wordQuery)
            {
                Console.Write("{0}{1}", letter.Key, letter.Count());
            }
            
        }
    }
}
