namespace LearninManagmentSystem.Data.Model;

public class  Class: BaseEntity
{
    public Course Course { get; set; }
    public DateTime Date { get; set; }
    public string Title { get; set; }
}