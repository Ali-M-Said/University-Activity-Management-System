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

            string query = $@"SELECT * FROM Users WHERE Email = '{email}' AND Password = '{password}';";
            return dbMan.ExecuteReader(query);
        }


        private bool IsPasswordCorrect(string email, string password)
        {
            string query = $@"SELECT COUNT(*) FROM Users WHERE Email = '{email}' AND Password = '{password}'";

            DataTable dt = dbMan.ExecuteReader(query);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public string AddUser(string firstname, string lastname, string email, string department, string password, string userType)
        {
            if (IsEmailRegistered(email))
                return "Email is already registered.";

            if (!IsValidPassword(password))
                return "Password must be at least 8 characters long and include an uppercase letter, a number, and a special character.";

            string query = $@"INSERT INTO Users (FName, LName, Email, Department, Password, Type) " +
                           $@"VALUES ('{firstname}', '{lastname}', '{email}', '{department}', '{password}', '{userType}')";

            int result = dbMan.ExecuteNonQuery(query);
            return result > 0 ? "User successfully registered." : "Error during registration.";
        }
        public DataTable department()
        {
            string query = "SELECT DISTINCT Department FROM Users;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable usertype()
        {
            string query = "SELECT DISTINCT Type FROM Users;";
            return dbMan.ExecuteReader(query);
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
            string query = $@"UPDATE Users SET Password = '{newPassword}' WHERE Email = '{email}'";

            int result = dbMan.ExecuteNonQuery(query);

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
            string query = $@"SELECT COUNT(*) FROM Users WHERE Email = '{email}'";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
        public DataTable GetUserById(int userId)
        {
                string query = $@"SELECT FirstName, LastName, Year, Email, Department, Type FROM Users WHERE UserID = '{userId}'";

                return dbMan.ExecuteReader(query);
        }


        public int GetStudentYear(int userId)
        {
            string query = $@"SELECT Year FROM Student WHERE UserID = '{userId}'";

            DataTable result = dbMan.ExecuteReader(query);
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["Year"]) : 0;
        }

        public DataTable GetActivityHistory(int userId)
        {
            string query = $@"
        SELECT c.Name AS ClubName, cm.JoinDate, cm.Mem_Status
        FROM Club_Membership cm
        INNER JOIN Club c ON cm.ClubID = c.ClubID
        WHERE cm.UserID = '{userId}'
        UNION
        SELECT e.Title AS EventTitle, a.CheckInTime, a.Status
        FROM Attendance a
        INNER JOIN Event e ON a.EventID = e.EventID
        WHERE a.UserID = '{userId}'";

            return dbMan.ExecuteReader(query);
        }


        public bool UpdateUserProfile(int userId, string firstName, string lastName, string email, string department, string userType)
        {
            string query = $@"
        UPDATE Users
        SET FName = '{firstName}',
            LName = '{lastName}',
            Email = '{email}',
            Department = '{department}' , Type = '{userType}'
        WHERE UserID = '{userId}'";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected > 0;
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
