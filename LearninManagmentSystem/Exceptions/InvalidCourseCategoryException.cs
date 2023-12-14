namespace LearninManagmentSystem.Exceptions;
 


public class InvalidCourseCategoryException : Exception
{
    public InvalidCourseCategoryException(string message) : base(message) { }
}