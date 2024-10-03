using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize.Exercises
{
    internal class GradeStudent
    {

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> FinalroundedGrades = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                int grade = grades[i];

                if (grade < 38)
                {
                    // If the grade is less than 38, no rounding occurs (because it's a failing grade).
                    FinalroundedGrades.Add(grade);
                }
                else
                {
                    // Calculate the next multiple of 5
                    int nextMultipleOf5 = ((grade / 5) + 1) * 5;

                    // Check the difference between grade and nextMultipleOf5
                    if (nextMultipleOf5 - grade < 3)
                    {
                        FinalroundedGrades.Add(nextMultipleOf5); // Round up if the difference is less than 3
                    }
                    else
                    {
                        FinalroundedGrades.Add(grade); // No rounding if the difference is 3 or more
                    }
                }
            }

            return FinalroundedGrades; // Return the rounded grades
        }

    }
}
