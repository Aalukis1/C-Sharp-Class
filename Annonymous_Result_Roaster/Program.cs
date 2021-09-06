
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;

using System.Linq;

namespace Annonymous_Result_Roaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ ANNONYMOUS SCHOOL RESULT ROASTER ==========");

            //create a random student scores
            Random StudentScores = new Random();

            // declare and initialize a list to contain the scores
            List<int> Scores = new List<int>();

            //add the scores to list
            for(int i=0; i<StudentScores.Next(10,200); i++)
            {
                Scores.Add(StudentScores.Next(1,100));
            }

            Console.WriteLine( Scores.Count() + " students partook in the exam");

            int Passed = 0;
            int Average = 0;
            int Failed = 0;

            // count the number of passed, average and failed students
            for(int j=0; j<Scores.Count(); j++)
            {
                if(Scores[j] > 70)
                {
                    Passed++;
                }

                else if(Scores[j]>50 && Scores[j] < 69)
                {
                    Average++;
                }

                else
                {
                    Failed++;
                }
            }

            // Display the results

            Console.WriteLine("Total Number of students is " + Scores.Count());
            Console.WriteLine("The number of students that Passed (above 70) is " + Passed);
            Console.WriteLine("The number of students that scored average between (50 and 69) is " + Average);
            Console.WriteLine("the number of students that failed is " + Failed);

            //to get scores of the students
            for(int k=0; k< Scores.Count(); k++)
            {
                Console.WriteLine("The Scores of all the students are: " + Scores[k]);
            }
            

        }
    }
}
