namespace SimplyRugby_System
{
    /// <summary>
    /// Represents an authenticated system user within the Simply Rugby application.
    /// Serves as the primary entity for managing Role-Based Access Control (RBAC) and user identity.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique database identifier for the user.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the unique login credential name.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the assigned authorization role, such as "Coach" or "Secretary".
        /// This value determines the accessibility of specific system modules and UI elements.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Evaluates if the user's role grants administrative or clerical permissions.
        /// </summary>
        /// <returns>True if the user belongs to the "Secretary" or "Admin" roles; otherwise, false.</returns>
        public bool IsAdminOrSecretary()
        {
            return Role == "Secretary" || Role == "Admin";
        }
    }
}