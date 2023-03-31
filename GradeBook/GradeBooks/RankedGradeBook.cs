using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            var gradeList = new List<double>
            {
                averageGrade
            };

            var sumOfGrades = +averageGrade;

            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work.");
            }

 
            return 'F';
        }
    }
}
