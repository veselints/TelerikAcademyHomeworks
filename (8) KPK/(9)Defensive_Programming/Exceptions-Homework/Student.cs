using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.exams = exams;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new NullReferenceException("First name cannot be null or empty.");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new NullReferenceException("Last name cannot be null or empty.");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get { return new List<Exam>(this.exams); }
        private set
        {
            if (this.Exams == null)
            {
                throw new NullReferenceException("Set of exams cannot be null.");
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentException("You have given an empty set of exams.");
            }

            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        return this.Exams.Select(t => t.Check()).ToList();
    }

    public double CalcAverageExamResultInPercents()
    {
        var examScore = new double[this.Exams.Count];
        var examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
