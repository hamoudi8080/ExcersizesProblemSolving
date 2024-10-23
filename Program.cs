using Excersize.Exercises;
using Exercise.Exercises;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

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


            /*
             * GradeStudent 

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
            */



            /*
             *  CompareTriplets

            List<int> alice = new List<int> { 4, 7 ,7 };
            List<int> bob = new List<int> { 1, 7, 3 };

            var compare = CompareTriplets.compareTriplets(alice, bob);

            Console.WriteLine("Alice's Score: " + compare[0]);
            Console.WriteLine("Bob's Score: " + compare[1]);
            */


            /*
             * AmbiguousCoordinates

            // Example input
            string input = "(123)";

            // Create an instance of the Solution class and call the method
            var solution =  AmbiguousCoordinates.AmbiguousCoordinatesFunction(input);


            // Print the result
            foreach (var coordinate in solution)
            {
                Console.WriteLine(coordinate);
            }

            */


            /*
             * Sentence_Similarity
            string sentence1 = "My name is Haley";
            string sentence2 = "My Haley";

            bool result = Sentence_Similarity.AreSentencesSimilar(sentence1, sentence2);
            Console.WriteLine(result);
            */

            /*
             * RemoveDuplicatessSolution
            int[] nums = { 1, 1, 2, 3};
            var k = RemoveDuplicatessSolution.RemoveDuplicates(nums);

            for (int i = 0; i < k; i++)
            {
                Console.Write(nums[i] + " ");
            }
            */



            /*
             * Multithreads
             * https://stackify.com/c-threading-and-multithreading-a-guide-with-examples/
             *  Multithreads.Multithreadss();
             */


            /*
             * RemoveDuplicatess2Solution
            int[] nums = { 1, 1,1,2, 2, 3 };
            var k = RemoveDuplicatess2Solution.RemoveDuplicates(nums);

            for (int i = 0; i < k; i++)
            {
                Console.Write(nums[i] + " ");
            }
            */



            /*
             * MajorityElementSolution

            int[] nums = { 2, 2, 1, 1, 1, 3, 3, 3, 3, 3 };

            int majority=  MajorityElementSolution.MajorityElement(nums);

            Console.WriteLine("The majority element is: " + majority);
            */





            /*
             * RotateSolution
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            int k = 3;

            int[] rotatedArray = RotateSolution.Rotate(nums, k);

            // Print the result
            Console.WriteLine(string.Join(", ", rotatedArray));
            */

            /*
            int[] nums = [7, 1, 5, 3, 6, 4];
            int result = MaxProfitSolution.MaxProfit(nums);
            Console.WriteLine(result);
            */

            /*
             * MaxProfitSolution2
            int[] nums = [7, 1, 5, 3, 6, 4];
            int result = MaxProfitSolution2.MaxProfit(nums);
            Console.WriteLine(result);
            */


            /*
            int[] nums = [3, 2, 1, 0, 4];

            bool result = JumpGameSolution.CanJump(nums);
            Console.WriteLine(result);
            */

            int[] nums = [2, 7, 11, 15];
            int target = 26;
            var result = TwoSumSolution.TwoSum(nums, target);
            Console.WriteLine(result[0] + " " + result[1]);



        }
    }


}
