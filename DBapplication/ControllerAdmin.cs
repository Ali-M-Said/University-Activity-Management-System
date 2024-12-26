using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class ControllerAdmin
    {
        DBManager dbMan;
        public ControllerAdmin()
        {
            dbMan = new DBManager();
        }
        // Get Total Users
        public string GetTotalUsers()
        {
            string query = "SELECT COUNT(*) FROM Users";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        // Get Total Admins
        public string GetTotalAdmins()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Admin'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        // Get Total Faculty Members
        public string GetTotalFacultyMembers()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Faculty Member'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        // Get Total Students
        public string GetTotalStudents()
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Type = 'Student'";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        // Get Total Events
        public string GetTotalEvents()
        {
            string query = "SELECT COUNT(*) FROM Event";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        // Get Total Clubs
        public string GetTotalClubs()
        {
            string query = "SELECT COUNT(*) FROM Club";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }

        // Get Total Locations
        public string GetTotalLocations()
        {
            string query = "SELECT COUNT(*) FROM Location";
            return Convert.ToString(dbMan.ExecuteScalar(query));
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
      
    }
}
