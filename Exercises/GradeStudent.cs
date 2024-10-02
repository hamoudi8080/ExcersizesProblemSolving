using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize.Exercises
{
    internal class GradeStudent
    {
        /*
         HackerLand University has the following grading policy:

        Every student receives a  in the inclusive range from  to .
        Any  less than  is a failing grade.
        Sam is a professor at the university and likes to round each student's  according to these rules:

        If the difference between the  and the next multiple of  is less than , round  up to the next multiple of .
        If the value of  is less than , no rounding occurs as the result will still be a failing grade.
        Examples

         round to  (85 - 84 is less than 3)
         do not round (result is less than 40)
         do not round (60 - 57 is 3 or higher)
        Given the initial value of  for each of Sam's  students, write code to automate the rounding process.

        Function Description

        Complete the function gradingStudents in the editor below.

        gradingStudents has the following parameter(s):

        int grades[n]: the grades before rounding
        Returns

        int[n]: the grades after rounding as appropriate
        Input Format

        The first line contains a single integer, , the number of students.
        Each line  of the  subsequent lines contains a single integer, .

        Constraints

        Sample Input 0

        4
        73
        67
        38
        33
        Sample Output 0

        75
        67
        40
        33*/

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                int grade = grades[i];

                if (grade < 38)
                {
                    // If the grade is less than 38, no rounding occurs (because it's a failing grade).
                    roundedGrades.Add(grade);
                }
                else
                {
                    // Calculate the next multiple of 5
                    int nextMultipleOf5 = ((grade / 5) + 1) * 5;

                    // Check the difference between grade and nextMultipleOf5
                    if (nextMultipleOf5 - grade < 3)
                    {
                        roundedGrades.Add(nextMultipleOf5); // Round up if the difference is less than 3
                    }
                    else
                    {
                        roundedGrades.Add(grade); // No rounding if the difference is 3 or more
                    }
                }
            }

            return roundedGrades; // Return the rounded grades
        }

    }
}
