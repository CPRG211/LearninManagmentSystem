namespace LearninManagmentSystem.Exceptions;
 


public class InvalidStudentIdException : Exception
{
    public InvalidStudentIdException(string message) : base(message) { }
}