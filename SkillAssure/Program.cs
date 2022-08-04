public class SkillAssureTrainingModel
{
    public string ClientName { get; set; }
    public Iteration[] iterations { get; set; } = new Iteration[3];

}
public class Iteration
{
    public int IterationNo { get; set; }
    public string Goal { get; set; }

    public List<Course> courses { get; set; } = new List<Course>();
    public List<Assessment> assessments { get; set; } = new List<Assessment>();

}

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public List<Assessment> assessments { get; set; } = new List<Assessment>();
    public Course(Assessment assessment)
    {
        assessments.Add(assessment);
    }
}

public class Assessment
{
    public int AssesmentId { get; set; }
    public string Description { get; set; }
    public int NoOfQuestions { get; set; }
    public List<Question> questions { get; set; } = new List<Question>();




}

public class Question
{
    public int Marks { get; set; }
    public virtual int TotalNoOfQuestion()
    {
        return 0;
    }
}

public class MCQQuestion : Question
{
    public string QuestionName { get; set; }

    public string Option1 { get; set; }
    public string Option2 { get; set; }
    public string Option3 { get; set; }
    public string Option4 { get; set; }
    public string RightOption { get; set; }

    override public int TotalNoOfQuestion()
    {
        return 0;
    }

}

public class HandsOnQuestion : Question
{
    public string QuestionDescription { get; set; }
    public string ReferenceDocument { get; set; }

    override public int TotalNoOfQuestion()
    {
        return 0;
    }

}