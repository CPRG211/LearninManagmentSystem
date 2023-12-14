
using LearninManagmentSystem.Data;
using LearninManagmentSystem.Data.Model;
using MySql.Data.MySqlClient;

public class CourseManager : BaseManager
{
    public List<Course> GetAllCourses()
    {
        var courses = new List<Course>();

        using (var connection = new MySqlConnection(ConnectionString))
            
        {
            Console.WriteLine(connection.ConnectionString);
            connection.Open();

            var sql = "select  c.*,ct.categoryname from  Course c inner join Category ct on c.categoryId=ct.id"; 

            using (var command = new MySqlCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var course = new Course
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("courseName"),
                            StartDate = reader.GetDateTime("StartDate"),
                            EndDate = reader.GetDateTime("EndDate"),
                            Abstract = reader.GetString("Abstract"),
                            Bibliography = reader.GetString("Bibliography"),
                            Category = new Category 
                            {
                                // Populate Category properties based on your database schema
                                Id = reader.GetInt32("categoryId"),
                                Name = reader.GetString("categoryName")
                            }
                        };

                        courses.Add(course);
                    }
                }
            }
        }

        return courses;
   
    }

    public List<Category> GetAllCategories()
    {
        var categories = new List<Category>();

        using (var connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            var sql = "SELECT * FROM Category";

            using (var command = new MySqlCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new Category
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("categoryName")
                        };
                        categories.Add(category);
                    }
                }
            }
        }

        return categories;
    }
}