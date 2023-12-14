

using LearninManagmentSystem.Model;

namespace LearninManagmentSystem.Data.Model;
/// <summary>
/// Class <c>Enrollment</c> models for Enroll a student to a <c>Course<c>.0
/// /// </summary>
public class Enrollment: BaseEntity
{
    public Student Student { get; set; }
    public Course Course { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public CancellationReason CancellationReason { get; set; }
}