﻿using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved;

	public SimpleMathExam(int problemsSolved)
	{
		this.problemsSolved = problemsSolved;
	}

	public int ProblemsSolved
	{
		get { return this.problemsSolved; }
		private set
		{
			if (value < 0 || value > 10)
			{
				throw new ArgumentException("Value of problemsSolved should be in between 0 and 10 incusive.");
			}

			this.problemsSolved = value;
		}
	}

	public override ExamResult Check()
	{
		switch (this.ProblemsSolved)
		{
			case 0:
				return new ExamResult(2, 2, 6, "Bad result: nothing done.");
			case 1:
				return new ExamResult(4, 2, 6, "Average result: nothing done.");
			case 2:
				return new ExamResult(6, 2, 6, "Average result: nothing done.");
		}

		return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
	}
}
