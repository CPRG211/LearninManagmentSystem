using System.Text.RegularExpressions;
using LearninManagmentSystem.Data.Model;
using LearninManagmentSystem.Exceptions;

namespace LearninManagmentSystem.Model;

public class Student:  ContactInfoBase
{
    public int Id { get; set; }
    public string Identifier{ get; set; }
    public DateTime DateOfBirth { get; set; }

	/// <summary>
	/// Method <c>Validate</c> Validate student name , phone and date of birth.
	/// </summary>
	public void Validate()
    {
        ValidateTelephoneNumber();
        ValidateName();
        ValidateDateOfBirth();
    }
    
    private void ValidateDateOfBirth()
    {
        // Add date of birth validation logic
        if (DateTime.Now.Year - DateOfBirth.Year > 80)
        {
            throw new LearninManagmentSystem.Exceptions.InvalidDataException("Age must be less than 80 years.");
        }
    }
    
    private void ValidateName()
    {
        // Check if the name is not null or empty
        if (string.IsNullOrEmpty(Name))
        {
            throw new InvalidStudentDataException("Name is required.");
        }

        // Check if the name length is within the allowed limit
        if (Name.Length > 40)
        {
            throw new InvalidStudentDataException("Name cannot be longer than 40 characters.");
        }

        // Check if the name contains only letters and spaces
        if (!Regex.IsMatch(Name, "^[a-zA-Z\\s]+$"))
        {
            throw new InvalidStudentDataException("Name cannot contain special characters.");
        }
    }
    
    private void ValidateTelephoneNumber()
    {
        // Check if the telephone number is not null or empty
        if (string.IsNullOrEmpty(TelephoneNumber))
        {
            throw new InvalidStudentDataException("Telephone Number is required.");
        }

        // Check if the telephone number contains only digits
        if (!Regex.IsMatch(TelephoneNumber, "^[0-9]+$"))
        {
            throw new InvalidStudentDataException("Telephone Number must contain only digits.");
        }

        // Check if the telephone number length is within the allowed limit
        if (TelephoneNumber.Length != 10)
        {
            throw new InvalidStudentDataException("Telephone Number must be 10 digits.");
        }
    }
    
}