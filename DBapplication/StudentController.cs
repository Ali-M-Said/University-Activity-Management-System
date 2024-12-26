using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBapplication
{
    public class StudentController
    {
        DBManager dbMan;
        public StudentController()
        {
            dbMan = new DBManager();
        }
         public int ResCount(int userid)
        {
            string query = $@"SELECT Count(*) FROM Reservation WHERE USERID = '{userid}'";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));

        }
        public int EventCount(int userid)
        {
            string query = $@"SELECT COUNT(*) FROM Event e JOIN Attendance a ON e.EventID = a.EventID WHERE a.UserID = '{userid}' AND e.StartDate > GETDATE();";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));

        }
        public int ClubCount(int userid)
        {
            string query = $@"SELECT COUNT(*) FROM Club_Membership cm WHERE cm.userid = '{userid}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));

        }
        public DataTable GetAvailableSpacesForReservation()
        {
         
            DataTable availableSpaces = new DataTable();
            string query = @" SELECT LocationId, LocName, Capacity, LocType, StartTime, EndTime FROM Location "; 
            availableSpaces=dbMan.ExecuteReader(query);
            return availableSpaces;
        }
        public bool ReserveLocation(int userId, int locationId, string startTime, string endTime)
        {
            // Single query to validate and insert if the time range is valid
            string query = $@"
        INSERT INTO Reservation (UserID, LocationID, StartTime, EndTime)
        SELECT '{userId}', '{locationId}', '{startTime}', '{endTime}'
        WHERE EXISTS (
            SELECT 1 
            FROM Location 
            WHERE LocationID = '{locationId}'
              AND CAST('{startTime}' AS TIME) >= StartTime 
              AND CAST('{endTime}' AS TIME) <= EndTime
        )";

            // Execute the query and check if a row was inserted
            int rowsAffected = dbMan.ExecuteNonQuery(query);

            // Return true if the reservation was successfully inserted
            return rowsAffected > 0;
        }
        public DataTable LoadAttendedEvents(int userId)
        {
            string query = $@"
        SELECT e.EventID, e.Title 
        FROM Event e
        INNER JOIN Attendance a ON e.EventID = a.EventID
        WHERE a.UserID = {userId}
    ";

            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
            
        }

        public bool ProvideFeedback(int userId,int eventId,int rating,string comment)
        {
           

           
            string query = $@"
        INSERT INTO Feedback (UserID, EventID, Ratings, Comments)
        VALUES ('{userId}', '{eventId}', '{rating}', '{comment}')
    ";

            // Execute the query and check if a row was inserted
            int rowsAffected = dbMan.ExecuteNonQuery(query);

            // Return true if the feedback was successfully inserted
            return rowsAffected > 0;
        }

        public DataTable GetReservationHistoryForStudent(int userId)
        {
            DataTable reservationHistory = new DataTable();
            string query = $@"
        SELECT 
            r.ReservationID,
            r.UserID,
            u.FName + ' ' + u.LName AS StudentName,
            l.LocName AS Location,
            r.StartTime,
            r.EndTime
        FROM Reservation r
        INNER JOIN Users u ON r.UserID = u.UserID
        INNER JOIN Location l ON r.LocationID = l.LocationID
        WHERE r.UserID = '{userId}'
        ORDER BY r.ReservationID DESC;
    ";

            // Assuming ExecuteReader executes the query and maps it to the DataTable
            reservationHistory = dbMan.ExecuteReader(query);
            return reservationHistory;
        }
        public DataTable GetUpcomingEvents()
        {
            DataTable upcomingEvents = new DataTable();
            string query = @"
        SELECT 
            e.EventID,
            e.Title,
            e.Description,
            e.StartDate,
            e.EndDate,
            e.EventCategory,
            l.LocName AS Location,
            u.FName + ' ' + u.LName AS CreatedBy
        FROM Event e
        INNER JOIN Location l ON e.LocationID = l.LocationID
        INNER JOIN Users u ON e.CreatedBy = u.UserID
        WHERE e.StartDate < CAST(GETDATE() AS DATE)
        ORDER BY e.StartDate ASC;
    ";

            // Assuming ExecuteReader executes the query and maps it to the DataTable
            upcomingEvents = dbMan.ExecuteReader(query);
            return upcomingEvents;
        }
        public bool RegisterStudentInEvent(int userID, int eventID)
        {
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM Attendance 
        WHERE UserID = '{userID}' 
        AND EventID = '{eventID}'";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations > 0)
            {
                return false;
            }

            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string insertQuery = $@" INSERT INTO Attendance (UserID, EventID, CheckInTime, Status) VALUES ('{userID}', '{eventID}', '{currentTime}', 'Checked In')";

            int rowsAffected = dbMan.ExecuteNonQuery(insertQuery);
            return rowsAffected > 0;
        }



        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
      
    }
}
