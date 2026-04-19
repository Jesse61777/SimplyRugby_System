using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// Centralized business logic layer for all player-related data operations.
    /// Handles registration, updates, deletions, and retrieval of performance assessments.
    /// </summary>
    public static class PlayerManager
    {
        /// <summary>
        /// Retrieves all registered players for the directory listing.
        /// </summary>
        /// <returns>A DataTable containing basic information for all players.</returns>
        public static DataTable GetAllPlayers()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT PlayerID, FullName, EmergencyContact, Category FROM Players";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to retrieve player directory: {ex.Message}");
            }
            return dt;
        }

        /// <summary>
        /// Persists player skill evaluation data to the database.
        /// Standardized to use PassRating, TackleRating, and CoachNotes (v2.2 Schema).
        /// </summary>
        /// <param name="pid">The unique identifier of the player.</param>
        /// <param name="pass">The pass skill rating score.</param>
        /// <param name="tackle">The tackle skill rating score.</param>
        /// <param name="notes">Additional notes provided by the coach.</param>
        /// <returns>True if the assessment was successfully saved or updated; otherwise, false.</returns>
        public static bool SaveAssessment(int pid, int pass, int tackle, string notes)
        {
            string sql = @"INSERT INTO SkillAssessments (PlayerID, PassRating, TackleRating, CoachNotes, DateAssessed) 
                           VALUES (@pid, @pass, @tackle, @notes, NOW()) 
                           ON DUPLICATE KEY UPDATE 
                           PassRating=@pass, TackleRating=@tackle, CoachNotes=@notes, DateAssessed=NOW()";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.Parameters.AddWithValue("@pass", pass);
                        cmd.Parameters.AddWithValue("@tackle", tackle);
                        cmd.Parameters.AddWithValue("@notes", notes);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database Save Failure: {ex.Message}");
            }
        }

        /// <summary>
        /// Retrieves the most recent skill assessment recorded for a specific player.
        /// </summary>
        /// <param name="playerID">The unique identifier of the player.</param>
        /// <returns>A DataTable containing the latest assessment ratings and notes.</returns>
        public static DataTable GetLatestAssessment(int playerID)
        {
            DataTable dt = new DataTable();
            string sql = @"SELECT PassRating, TackleRating, CoachNotes 
                           FROM SkillAssessments 
                           WHERE PlayerID = @pid 
                           ORDER BY AssessmentID DESC LIMIT 1";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@pid", playerID);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to retrieve latest player assessment: {ex.Message}");
            }
            return dt;
        }

        /// <summary>
        /// Persists a new player record into the system, automatically determining their category.
        /// </summary>
        /// <param name="name">The full name of the new player.</param>
        /// <param name="dob">The player's date of birth.</param>
        /// <param name="address">The player's residential address.</param>
        /// <param name="guardian">The name of the player's guardian.</param>
        /// <param name="phone">The emergency contact phone number.</param>
        /// <param name="medical">Relevant medical conditions or notes.</param>
        /// <returns>True if the registration was successful; otherwise, false.</returns>
        public static bool RegisterNewPlayer(string name, DateTime dob, string address, string guardian, string phone, string medical)
        {
            Player modelCheck = new Player { DateOfBirth = dob };
            string category = modelCheck.IsJunior() ? "Junior" : "Senior";

            string sql = @"INSERT INTO Players (FullName, DateOfBirth, Address, GuardianName, EmergencyContact, MedicalInfo, Category) 
                           VALUES (@name, @dob, @address, @guardian, @phone, @med, @cat)";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@dob", dob.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@guardian", guardian);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@med", medical);
                        cmd.Parameters.AddWithValue("@cat", category);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Player registration failed: {ex.Message}");
            }
        }

        /// <summary>
        /// Updates an existing player's profile information.
        /// </summary>
        /// <param name="id">The unique identifier of the player being updated.</param>
        /// <param name="name">The updated full name.</param>
        /// <param name="address">The updated residential address.</param>
        /// <param name="guardian">The updated guardian name.</param>
        /// <param name="phone">The updated emergency contact phone number.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public static bool UpdatePlayerProfile(int id, string name, string address, string guardian, string phone)
        {
            string sql = @"UPDATE Players SET FullName = @name, Address = @addr, 
                           GuardianName = @guard, EmergencyContact = @phone WHERE PlayerID = @id";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@addr", address);
                        cmd.Parameters.AddWithValue("@guard", guardian);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Profile update failed: {ex.Message}");
            }
        }

        /// <summary>
        /// Removes a player record from the system.
        /// </summary>
        /// <param name="id">The unique identifier of the player to delete.</param>
        /// <returns>True if the deletion was successful; otherwise, false.</returns>
        public static bool DeletePlayer(int id)
        {
            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Players WHERE PlayerID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Deletion failed: {ex.Message}");
            }
        }
    }
}