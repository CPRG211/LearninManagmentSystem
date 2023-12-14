namespace LearninManagmentSystem.Data.Model;

public class Exam: BaseEntity
{
    public Course Course { get; set; }
    public DateTime ExamDate { get; set; }
    public string Topics { get; set; }
}