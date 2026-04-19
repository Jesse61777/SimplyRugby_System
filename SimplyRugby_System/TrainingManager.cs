using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// Handles database operations for training sessions and attendance.
    /// Fully implements CRUD capabilities with relational mapping.
    /// </summary>
    public static class TrainingManager
    {
        /// <summary>
        /// Records a session and saves the list of attended players via a database transaction.
        /// </summary>
        /// <param name="activities">The training activities or drills performed.</param>
        /// <param name="accidents">Details of any accidents or injuries.</param>
        /// <param name="playerIds">A list of player IDs who attended the session.</param>
        /// <returns>True if the session and attendance were successfully recorded; otherwise, false.</returns>
        public static bool RecordSession(string activities, string accidents, List<int> playerIds)
        {
            string sqlSession = "INSERT INTO TrainingSessions (Activities, Accidents, SessionDate) VALUES (@act, @acc, NOW()); SELECT LAST_INSERT_ID();";
            string sqlAttend = "INSERT INTO TrainingAttendance (SessionID, PlayerID) VALUES (@sid, @pid)";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        int newSessionId = 0;

                        using (MySqlCommand cmd = new MySqlCommand(sqlSession, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@act", activities);
                            cmd.Parameters.AddWithValue("@acc", accidents);
                            newSessionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        if (playerIds != null && playerIds.Count > 0)
                        {
                            using (MySqlCommand cmd = new MySqlCommand(sqlAttend, conn, trans))
                            {
                                cmd.Parameters.Add("@sid", MySqlDbType.Int32);
                                cmd.Parameters.Add("@pid", MySqlDbType.Int32);

                                foreach (int pid in playerIds)
                                {
                                    cmd.Parameters["@sid"].Value = newSessionId;
                                    cmd.Parameters["@pid"].Value = pid;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Save failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves sessions along with a comma-separated list of attending players.
        /// </summary>
        /// <param name="limit">The maximum number of recent sessions to retrieve.</param>
        /// <returns>A DataTable containing recent training sessions and their attendees.</returns>
        public static DataTable GetRecentSessions(int limit)
        {
            DataTable dt = new DataTable();

            string sql = @"
                SELECT 
                    ts.SessionID, 
                    DATE_FORMAT(ts.SessionDate, '%Y-%m-%d') AS 'Date', 
                    ts.Activities AS 'Focus / Drills', 
                    ts.Accidents AS 'Injury Report',
                    IFNULL(GROUP_CONCAT(p.FullName SEPARATOR ', '), 'None') AS 'Attendees'
                FROM TrainingSessions ts
                LEFT JOIN TrainingAttendance ta ON ts.SessionID = ta.SessionID
                LEFT JOIN Players p ON ta.PlayerID = p.PlayerID
                GROUP BY ts.SessionID
                ORDER BY ts.SessionDate DESC 
                LIMIT @limit";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@limit", limit);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Retrieve failed: " + ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// Updates the details of an existing training session.
        /// </summary>
        /// <param name="sessionId">The unique identifier of the training session.</param>
        /// <param name="activities">The updated training activities.</param>
        /// <param name="accidents">The updated accident or injury report.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public static bool UpdateSession(int sessionId, string activities, string accidents)
        {
            string sql = "UPDATE TrainingSessions SET Activities = @act, Accidents = @acc WHERE SessionID = @id";
            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@act", activities);
                        cmd.Parameters.AddWithValue("@acc", accidents);
                        cmd.Parameters.AddWithValue("@id", sessionId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Update failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Deletes a specific training session from the database.
        /// </summary>
        /// <param name="sessionId">The unique identifier of the training session to delete.</param>
        /// <returns>True if the deletion was successful; otherwise, false.</returns>
        public static bool DeleteSession(int sessionId)
        {
            string sql = "DELETE FROM TrainingSessions WHERE SessionID = @id";
            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", sessionId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Delete failed: " + ex.Message);
            }
        }
    }
}