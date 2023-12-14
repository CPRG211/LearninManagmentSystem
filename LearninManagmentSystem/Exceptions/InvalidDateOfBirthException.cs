namespace LearninManagmentSystem.Exceptions;
 


public class InvalidDateOfBirthException : Exception
{
    public InvalidDateOfBirthException(string message) : base(message) { }
}