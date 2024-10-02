using Excersize.Exercises;
using System;
using System.Collections.Generic;

namespace Exersize1
{

    public static class MyListFunction
    {
        public static int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }

        public static void MySortFunction(this List<int> li)
        {

            int temp;

            for (int i = 0; i < li.Count; i++)
            {

                for (int j = 0; j < li.Count; j++)
                {
                    if (li[i] < li[j])
                    {

                        //Swap
                        temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          

            /*
             * WeightSort

            // Example input
            string input = "56 65 74 100 99 68 86 180 90";

            // Call the orderWeight method from the WeightSort class
            string result = WeightSort.orderWeight(input);

            // Print the result
            Console.WriteLine(result);
            */


            /*
             * Name

            string[] names = { "Alice", "Bob", "Brian", "Charlie", "David", "Bella", "Emma", "George", "Hannah", "Ian" };

            var nameResult = Name.namesFunction(names);

            */



            // Create a list of grades
            List<int> grades = new List<int> { 73, 67, 38, 33 };

            // Call the gradingStudents function
            var roundedGrades = GradeStudent.gradingStudents(grades);

            // Output the results
            Console.WriteLine("Rounded Grades:");
            foreach (int roundedGrade in roundedGrades)
            {
                Console.WriteLine(roundedGrade);
            }


        }
    }


}
