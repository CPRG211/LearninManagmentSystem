using LearninManagmentSystem.Data.Model;
namespace LearninManagmentSystem.Data.Model;


/// <summary>
/// Class <c>Course</c> models for courses has a relation to the <c>Category<c>.
/// </summary>
public class Course: BaseEntity
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Category Category { get; set; }
    public string Abstract { get; set; }
    public string Bibliography { get; set; }
}