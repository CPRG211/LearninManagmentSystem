
using LearninManagmentSystem.Model;

namespace LearninManagmentSystem.Data.Model;

public class Attendance: IEntity
{
    public int Id { get; set; }
    public int ClassId { get; set; }
    public Student Student { get; set; }
    public DateTime ArrivalTime { get; set; }
    public DateTime DepartureTime { get; set; }
}