using System;
using MySql.Data.MySqlClient;

namespace SimplyRugby_System
{
    /// <summary>
    /// Coordinates performance data for matches and skill assessments.
    /// Acts as the business bridge for player development tracking.
    /// </summary>
    public static class CompetitionManager
    {
        /// <summary>
        /// Records a full match report into the database.
        /// </summary>
        public static bool RecordMatch(string opposition, DateTime date, string location, int s1Us, int s1Them, string comm1, int fUs, int fThem, string comm2)
        {
            string sql = @"INSERT INTO Matches (Opposition, MatchDate, Location, Score1stUs, Score1stThem, Comments1stHalf, FinalScoreUs, FinalScoreThem, Comments2ndHalf) 
                           VALUES (@opp, @date, @loc, @s1u, @s1t, @c1, @fu, @ft, @c2)";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@opp", opposition);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@loc", location);
                        cmd.Parameters.AddWithValue("@s1u", s1Us);
                        cmd.Parameters.AddWithValue("@s1t", s1Them);
                        cmd.Parameters.AddWithValue("@c1", comm1);
                        cmd.Parameters.AddWithValue("@fu", fUs);
                        cmd.Parameters.AddWithValue("@ft", fThem);
                        cmd.Parameters.AddWithValue("@c2", comm2);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (MySqlException ex) { throw new Exception($"Match record error: {ex.Message}"); }
        }

        /// <summary>
        /// Persists a quantitative skill assessment for a specific player.
        /// </summary>
        public static bool SaveAssessment(int playerId, int passing, int tackling, string comments)
        {
            string sql = "INSERT INTO SkillAssessments (PlayerID, Passing, Tackling, Comments, DateAssessed) VALUES (@id, @p, @t, @c, @d)";

            try
            {
                using (MySqlConnection conn = DbHelper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", playerId);
                        cmd.Parameters.AddWithValue("@p", passing);
                        cmd.Parameters.AddWithValue("@t", tackling);
                        cmd.Parameters.AddWithValue("@c", comments);
                        cmd.Parameters.AddWithValue("@d", DateTime.Now);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (MySqlException ex) { throw new Exception($"Assessment sync error: {ex.Message}"); }
        }
    }
}