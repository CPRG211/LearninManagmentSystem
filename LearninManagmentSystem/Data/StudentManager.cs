using LearninManagmentSystem.Model;
using LearninManagmentSystem.Data;
using MySql.Data.MySqlClient;

namespace LearninManagmentSystem.Data;

public class StudentManager :BaseManager
{
    public void AddStudent(Student student)
        
    {
        student.Validate();
        using (var connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            var sql = "INSERT INTO Student (Identifier, DateOfBirth, Name, Email, TelephoneNumber) " +
                      "VALUES (@Identifier, @DateOfBirth, @Name, @Email, @TelephoneNumber)";

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Identifier", student.Identifier);
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@TelephoneNumber", student.TelephoneNumber);

                command.ExecuteNonQuery();
            }
        }
    }
    
}