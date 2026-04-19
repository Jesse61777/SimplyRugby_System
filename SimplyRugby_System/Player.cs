using System;

namespace SimplyRugby_System
{
    /// <summary>
    /// Represents the core business entity for a Rugby Player.
    /// Encapsulates standard information required by the Scottish Rugby Union (SRU) alongside fundamental business rules.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets the unique identifier for the player.
        /// </summary>
        public int PlayerID { get; set; }

        /// <summary>
        /// Gets or sets the player's full name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the player's date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the player's residential address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the emergency contact information for the player.
        /// </summary>
        public string EmergencyContact { get; set; }

        /// <summary>
        /// Gets or sets the player's medical information and history.
        /// </summary>
        public string MedicalInfo { get; set; }

        /// <summary>
        /// Calculates the player's exact current age based on their Date of Birth.
        /// </summary>
        /// <returns>The calculated integer age in years.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Date of Birth is set in the future.</exception>
        public int CalculateAge()
        {
            if (DateOfBirth > DateTime.Now)
            {
                throw new InvalidOperationException("A player's Date of Birth cannot exist in the future.");
            }

            int age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                age--;
            }

            return age;
        }

        /// <summary>
        /// Evaluates whether the player falls under the Junior category based on SRU age regulations.
        /// </summary>
        /// <returns>True if the calculated age is under 18; otherwise, false.</returns>
        public bool IsJunior()
        {
            return CalculateAge() < 18;
        }
    }
}