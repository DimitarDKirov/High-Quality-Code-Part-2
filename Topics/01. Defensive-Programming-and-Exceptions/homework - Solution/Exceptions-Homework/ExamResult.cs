using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("grade must be >=0");
        }

        if (minGrade < 0)
        {
            throw new ArgumentException("minGrade must be >=0");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("maxGrade must be greater than minGrade");
        }

        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentNullException("comments can not be null nor empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
