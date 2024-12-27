using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBapplication
{
    public class FacultyMemberControler
    {
        DBManager dbMan;
        public FacultyMemberControler()
        {
            dbMan = new DBManager();
        }
        public DataTable GetPendingMembershipsSupervised(int userID)
        {
            // SQL query to fetch pending memberships where the user is the supervisor
            string query = $@"
    SELECT cm.MembershipID, cm.UserID, cm.ClubID, cm.JoinDate, cm.Mem_Status
    FROM Club_Membership cm
    INNER JOIN Club c ON cm.ClubID = c.ClubID
    WHERE cm.Mem_Status = 'Pending' AND c.SupervisorID = {userID};
";

            // Execute the query and return the result as a DataTable
            DataTable pendingMemberships = dbMan.ExecuteReader(query);

            return pendingMemberships;
        }
        public DataTable GetFeedBacks(string EventName)
        {
       
                DataTable feedbacks = new DataTable();
                string query = $@"
        SELECT 
            f.FeedbackID,
            e.Title AS EventName,
            u.FName + ' ' + u.LName AS UserName,
            f.Ratings,
            f.Comments
        FROM Feedback f
        INNER JOIN Event e ON f.EventID = e.EventID
        INNER JOIN Users u ON f.UserID = u.UserID
        WHERE e.Title = '{EventName}'
        ORDER BY f.FeedbackID DESC;
    ";

                // Assuming ExecuteReader executes the query and maps it to the DataTable
                feedbacks = dbMan.ExecuteReader(query);
                return feedbacks;

            }
        public DataTable GetFeedbacks()
        {
            string query = "SELECT FeedbackID FROM Feedback";  // Get only the Feedback IDs or other relevant columns
            DataTable feedbacks = dbMan.ExecuteReader(query);  // Use your dbMan.ExecuteReader or other database methods
            return feedbacks;
        }

        public bool RecordAttendance(int studentId, int eventId, string checkInTime)
        {
            string checkQuery = $@"
        SELECT COUNT(*) 
        FROM Attendance 
        WHERE EVENTID= '{eventId}' AND USERID='{studentId}' ";

            int existingRegistrations = Convert.ToInt32(dbMan.ExecuteScalar(checkQuery));

            if (existingRegistrations > 0)
            {
                return false;
            }
            string query = $@"
        INSERT INTO Attendance (UserID, EventID, CheckInTime,Status)
        VALUES ('{studentId}', '{eventId}', '{checkInTime}','Checked IN')
    ";

            // Execute the query and check if a row was inserted
            int rowsAffected = dbMan.ExecuteNonQuery(query);

            // Return true if the attendance was successfully recorded
            return rowsAffected > 0;
        }
        public void PopulateEventNames(ComboBox comboBox)
        public void PopulateEventNames(ComboBox comboBox,int uid)
        {
            // SQL query to get all event names
            string query = "SELECT Title FROM Event";
            string query = $@"SELECT Title FROM Event Where Createdby='{uid}'";

            try
            {
                // Execute the query and get the data in a DataTable
                DataTable events = dbMan.ExecuteReader(query);

                // Clear existing items in the ComboBox
                comboBox.Items.Clear();

                // Loop through the DataTable and add event names to the ComboBox
                foreach (DataRow row in events.Rows)
                {
                    string eventName = row["Title"].ToString();
                    comboBox.Items.Add(eventName);
                }

                // Optionally, you can set the first item as the default selected item
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void DeleteFeedBack(int FeedBackId)
        {
            string query = $@"DELETE FROM FeedBack WHERE FeedbackID = {FeedBackId}";
            dbMan.ExecuteNonQuery(query);
        }
        public int GetEventIDByName(string eventName)
        {
            string query = $@"
        SELECT EventID
        FROM Event
        WHERE Title = '{eventName}'
    ";

            // Execute the query and retrieve the first result (EventID) directly
            object result = dbMan.ExecuteScalar(query);

            // Check if the result is not null and convert it to integer
            if (result != null)
            {
                return Convert.ToInt32(result);
            }

            // If no result was found, return -1 or any other default value indicating failure
            return -1;

        }
        public DataTable TrackAttendance(string EventName)
        {

            DataTable Attendance = new DataTable();
            string query = $@"
        SELECT 
            a.AttendanceID,
            e.Title AS EventName,
            u.FName + ' ' + u.LName AS UserName,
            a.CheckInTime,
            a.Status
        FROM Attendance a
        INNER JOIN Event e ON a.EventID = e.EventID
        INNER JOIN Users u ON a.UserID = u.UserID
        WHERE e.Title = '{EventName}'
        ORDER BY a.AttendanceID DESC;
    ";

            // Assuming ExecuteReader executes the query and maps it to the DataTable
            Attendance = dbMan.ExecuteReader(query);
            return Attendance;

        }
        public DataTable GetPendingMemberships()
        {
            // SQL query to fetch membership IDs with "Pending" status
            string query = @"
        SELECT MembershipID, UserID, ClubID, JoinDate , mem_status
        FROM Club_Membership
        WHERE mem_status = 'Pending'
    ";

            // Execute the query and return the result as a DataTable
            DataTable pendingMemberships = dbMan.ExecuteReader(query);
            return pendingMemberships;
        }
        public bool AcceptMembership(int membershipId)
        {
            // SQL query to update the mem_status
            string query = $@"
        UPDATE Club_Membership
        SET mem_status = 'Accepted'
        WHERE MembershipID = {membershipId} AND mem_status='Pending'" ;

            // Execute the query and check if the update was successful
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected > 0; // Return true if at least one row was affected
        }
        public bool RejectMembership(int membershipId)
        {
        
            string query = $@"
        UPDATE Club_Membership
        SET mem_status = 'Rejected'
        WHERE MembershipID = {membershipId} AND mem_Status='Pending' " ;

            // Execute the query and check if the update was successful
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            return rowsAffected > 0; // Return true if at least one row was affected
        }
        public int PendingCount()
        {
            string query = $@"SELECT COUNT(*) FROM Club_MemberShip c WHERE c.mem_status = 'Pending'";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }
        public void DeleteAttendance(int AttendanceID)
        {
            string query = $@"DELETE FROM Attendance WHERE AttendanceID = {AttendanceID}";
            dbMan.ExecuteNonQuery(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
