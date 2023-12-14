using LearninManagmentSystem.Data.Model;
using System.Runtime.InteropServices.JavaScript;

namespace LearninManagmentSystemLearning.Model;

public class Teacher: ContactInfoBase
{
    public int Id { get; set; }
    public DateTime HireDate{ get; set; }
}