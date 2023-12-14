using LearninManagmentSystem.Model;

namespace LearninManagmentSystem.Data.Model;

public class ExamResult: BaseEntity
{
    public Exam Exam { get; set; }
    public Student Student { get; set; }
    public float Score { get; set; }
}