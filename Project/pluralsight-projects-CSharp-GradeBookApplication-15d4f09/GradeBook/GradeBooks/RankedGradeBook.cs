using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook 
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name,isWeighted)    // this is used to call the both constructor
        {
            this.type = Enums.GradeBookType.Ranked;    
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(this.Students.Count<5)
            {
                throw new InvalidOperationException("Required Minimum 5 Student to work.");
            }

            var desc_student_grades = Students.OrderByDescending(x => x.AverageGrade);
            List<double> student_grades = new List<double>();
            foreach(var s in desc_student_grades)
            {
                student_grades.Add(s.AverageGrade);
            }

            int top20per = Convert.ToInt32(Students.Count * 0.2);

            if (student_grades.IndexOf(averageGrade) < top20per)
                return 'A';
            else if (student_grades.IndexOf(averageGrade) < 2*top20per)
                return 'B';
            else if (student_grades.IndexOf(averageGrade) < 3*top20per)
                return 'C';
            else if (student_grades.IndexOf(averageGrade) < 4*top20per)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            if(Students.Count<5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if(Students.Count<5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStatistics();
        }
    }
}
