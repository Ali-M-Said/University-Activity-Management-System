using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBapplication
{
    public class ControllerAdmin
    {
        DBManager dbMan;
        public ControllerAdmin()
        {
            dbMan = new DBManager();
        }
        public string GetTotalUsers()
        {
            string query = "SELECT COUNT(*) FROM Users";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalAdmins()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Admin'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalFacultyMembers()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Faculty Member'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalStudents()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Student'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalEvents()
        {
            string query = "SELECT COUNT(*) FROM Event";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalClubs()
        {
            string query = "SELECT COUNT(*) FROM Club";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public string GetTotalLocations()
        {
            string query = "SELECT COUNT(*) FROM Location";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public bool IsInvalidName(string Fname)
        {
            foreach (char c in Fname)
            {
                if (char.IsDigit(c) || !char.IsLetter(c))
                {
                    return true;
                }
            }
            return false; 
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;

            bool hasUpper = false, hasLower = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpper && hasLower && hasDigit;
        }
        public void AddAdmin(string FName, string LName, string Password, string Email)
        {
            string query = $@"INSERT INTO Users (FName, LName, Password, Email, Department, Type) " +
                           $@"VALUES ('{FName}', '{LName}', '{Password}', '{Email}', 'Adminstration', 'Admin')";
            dbMan.ExecuteNonQuery(query);
        }
        public DataTable AllUsers()
        {
            string query= "SELECT* FROM Users";
            return dbMan.ExecuteReader(query);
        }
        public bool DoesUserExist(int userId)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE UserID = {userId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        public bool DoesEventExist(int eventId)
        {
            string query = $"SELECT COUNT(*) FROM Event WHERE EventID = {eventId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        public bool DoesClubExist(int clubId)
        {
            string query = $"SELECT COUNT(*) FROM Club WHERE ClubID = {clubId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        public bool DoesLocationExist(int LocId)
        {
            string query = $"SELECT COUNT(*) FROM Location WHERE LocationID = {LocId}";
            int count = (int)dbMan.ExecuteScalar(query);
            return count > 0;
        }
        public void DeleteUser(int userId)
        {
            string query = $@"DELETE FROM Users WHERE UserID = {userId}";
            dbMan.ExecuteNonQuery(query);
        }
        public void DeleteEvent(int eventId)
        {
            string query = $@"DELETE FROM Event WHERE EventID = {eventId}";
            dbMan.ExecuteNonQuery(query);
        }
        public void DeleteClub(int clubId)
        {
            string query = $@"DELETE FROM Club WHERE ClubID = {clubId}";
            dbMan.ExecuteNonQuery(query);
        }
        public void DeleteLocation(int LocId)
        {
            string query = $@"DELETE FROM Location WHERE LocationID = {LocId}";
            dbMan.ExecuteNonQuery(query);
        }
        public string GenerateRandomPassword()
        {
            const int passwordLength = 8;
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialCharacters = "!@#$%^&*()_+";

            Random random = new Random();

            // Ensure the password contains at least one of each required character type
            char[] password = new char[passwordLength];
            password[0] = upperCase[random.Next(upperCase.Length)]; // At least one uppercase letter
            password[1] = lowerCase[random.Next(lowerCase.Length)]; // At least one lowercase letter
            password[2] = digits[random.Next(digits.Length)]; // At least one digit

            // Fill the rest of the password with random characters from all categories
            string allChars = upperCase + lowerCase + digits + specialCharacters;
            for (int i = 3; i < passwordLength; i++)
            {
                password[i] = allChars[random.Next(allChars.Length)];
            }

            // Shuffle the password to make it more random
            password = password.OrderBy(x => random.Next()).ToArray();

            return new string(password);
        }

        public string UpdateUserPassword(int userId)
        {
            string newPassword = GenerateRandomPassword();

            string query = $@"UPDATE Users SET Password = '{newPassword}' WHERE UserID = {userId}";

            dbMan.ExecuteNonQuery(query);
            return newPassword;
        }
        public void AddEvent(string title, string description, DateTime startDate, DateTime endDate, int eventCategory, int locationId, int createdBy)
        {
            string query = $@"
        INSERT INTO Event (Title, Description, StartDate, EndDate, EventCategory, LocationID, CreatedBy)
        VALUES ('{title}', '{description}', '{startDate}', '{endDate}', {eventCategory}, {locationId}, {createdBy})";

            dbMan.ExecuteNonQuery(query);
        }
        public void EditEvent(int eventId, string title, string description, DateTime startDate, DateTime endDate, int eventCategory, int locationId)
        {
            string query = $@"
        UPDATE Event
        SET Title='{title}', Description='{description}',StartDate= '{startDate}',EndDate= '{endDate}', EventCategory={eventCategory}, LocationID={locationId}
        WHERE EventID = {eventId}";
            dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetEventDetails(int eventId)
        {
            string query = $@"SELECT Title, Description, StartDate, EndDate, EventCategory, LocationID  FROM Event WHERE EventID = {eventId}";
            return dbMan.ExecuteReader(query);
        }
        public DataTable EventCategory()
        {
            string query = $" SELECT * FROM EventCategories";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Locations()
        {
            string query = $" SELECT * FROM Location";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Events()
        {
            string query = $" SELECT E.EventID, E.Title, E.Description, E.StartDate, E.EndDate,EC.CategoryName, L.LocName, CONCAT(U.FName, ' ', U.LName) AS Name FROM Event E, EventCategories EC, Location L, Users U WHERE E.EventCategory=EC.CategoryID AND L.LocationID=E.LocationID AND E.CreatedBy=U.UserID";
            return dbMan.ExecuteReader(query);
        }
        public void AddClub(string title, string description,int UserID)
        {
            string query = $@"
        INSERT INTO Club (Name, Description, SupervisorID)
        VALUES ('{title}', '{description}', {UserID})";

            dbMan.ExecuteNonQuery(query);
        }
        public DataTable FacultyMembers()
        {
            string query = $" SELECT UserID,CONCAT(FName, ' ', LName) AS Name FROM Users WHERE Type='Student'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Clubs()
        {
            string query = $" SELECT C.ClubID, C.Name, C.Description, CONCAT(U.FName, ' ', U.LName) AS Name FROM Club C,Users U WHERE C.SupervisorID=U.UserID";
            return dbMan.ExecuteReader(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
      
    }
}
