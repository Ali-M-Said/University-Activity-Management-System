using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public DataTable CheckEmailAndPassword(string email, string password)
        {

            string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password;";

            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@Email", email },
        { "@Password", password }
    };

            return dbMan.ExecuteReader(query, parameters);
        }


        private bool IsPasswordCorrect(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@Email", email },
        { "@Password", password }
    };

            DataTable dt = dbMan.ExecuteReader(query, parameters);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public string AddUser(string firstname, string lastname, string email, string department, string password, string userType)
        {
            // Check if the email already exists
            if (IsEmailRegistered(email))
                return "Email is already registered.";

            // Validate password strength
            if (!IsValidPassword(password))
                return "Password must be at least 8 characters long and include an uppercase letter, a number, and a special character.";

            // Hash the password before storing it
            //string hashedPassword = HashPassword(password); HASH YAEKHWATY

            // SQL query to insert a new user
            string query = "INSERT INTO Users (FName, LName, Email, Department, Password, Type) " +
                           "VALUES (@FName, @LName, @Email, @Department, @Password, @Type)";

            // Parameters for the query
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@FName", firstname },
                { "@LName", lastname },
                { "@Email", email },
                { "@Department", department },
                { "@Password", password },
                { "@Type", userType }
            };

            // Execute the query and return the result
            int result = dbMan.ExecuteNonQuery(query, parameters);
            return result > 0 ? "User successfully registered." : "Error during registration.";
        }
        public DataTable department()
        {
            string query = "SELECT DISTINCT Department FROM Users;";
            return dbMan.ExecuteReader(query, new Dictionary<string, object>());
        }

        public DataTable usertype()
        {
            string query = "SELECT DISTINCT Type FROM Users;";
            return dbMan.ExecuteReader(query, new Dictionary<string, object>());
        }

        public string ChangePassword(string email, string oldPassword, string newPassword)
        {
            // Hash the old password to check if it matches
            //string oldPasswordHash = HashPassword(oldPassword);  HWAR EL HASH AHO******

            // Validate old password
            if (!IsPasswordCorrect(email, oldPassword))
                return "Old password is incorrect.";

            // Hash the new password
            //string newPasswordHash = HashPassword(newPassword);

            // Update the password in the database
            string query = "UPDATE Users SET Password = @NewPassword WHERE Email = @Email";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@NewPassword", newPassword },
        { "@Email", email }
    };

            int result = dbMan.ExecuteNonQuery(query, parameters);

            return result > 0 ? "Password successfully updated." : "Error updating password.";
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;
            bool hasUpperCase = false, hasNumber = false, hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                else if (char.IsDigit(c)) hasNumber = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
            }

            return hasUpperCase && hasNumber && hasSpecialChar;
        }

        private bool IsEmailRegistered(string email)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@Email", email } };
            DataTable dt = dbMan.ExecuteReader(query, parameters);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public DataTable GetUserById(int userId)
        {
            try
            {
                string query = "SELECT FirstName, LastName, Year, Email, Department, Type FROM Users WHERE UserID = @UserId";
                var parameters = new Dictionary<string, object>
        {
            { "@UserId", userId }
        };

                // Use ExecuteQuery to retrieve the data
                return dbMan.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                MessageBox.Show($"Error retrieving user data: {ex.Message}");
                return null; // Return null in case of an error
            }
        }


        public int GetStudentYear(int userId)
        {
            string query = "SELECT Year FROM Student WHERE UserID = @UserId";
            var parameters = new Dictionary<string, object>
    {
        { "@UserId", userId }
    };

            DataTable result = dbMan.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["Year"]) : 0;
        }

        public DataTable GetActivityHistory(int userId)
        {
            string query = @"
        SELECT c.Name AS ClubName, cm.JoinDate, cm.Mem_Status
        FROM Club_Membership cm
        INNER JOIN Club c ON cm.ClubID = c.ClubID
        WHERE cm.UserID = @UserId
        UNION
        SELECT e.Title AS EventTitle, a.CheckInTime, a.Status
        FROM Attendance a
        INNER JOIN Event e ON a.EventID = e.EventID
        WHERE a.UserID = @UserId";

            var parameters = new Dictionary<string, object>
    {
        { "@UserId", userId }
    };

            return dbMan.ExecuteQuery(query, parameters);
        }


        public bool UpdateUserProfile(int userId, string firstName, string lastName, string email, string department, string userType)
        {
            string query = @"
        UPDATE Users
        SET FName = @FName,
            LName = @LName,
            Email = @Email,
            Department = @Department , Type = @UserType
        WHERE UserID = @UserID";

            // Create a dictionary for the parameters
            var parameters = new Dictionary<string, object>
    {
        { "@FName", firstName },
        { "@LName", lastName },
        { "@Email", email },
        { "@Department", department },
        { "@UserID", userId },
        { "@Type", userType }

    };

            try
            {
                int rowsAffected = dbMan.ExecuteNonQuery(query, parameters); // Pass the dictionary
                return rowsAffected > 0; // Return true if rows were updated
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }

} 
   // Hash the password using SHA256
        //private string HashPassword(string password)
        //{
        //    using (SHA256 sha256 = SHA256.Create())
        //    {
        //        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        StringBuilder builder = new StringBuilder();
        //        foreach (byte b in bytes)
        //            builder.Append(b.ToString("x2"));
        //        return builder.ToString();
        //    }
        //}
