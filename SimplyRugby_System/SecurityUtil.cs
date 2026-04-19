using System;
using System.Security.Cryptography;
using System.Text;

namespace SimplyRugby_System
{
    /// <summary>
    /// Provides system-level security utilities, specifically focusing on cryptographic functions.
    /// Fulfills advanced security requirements by preventing plain-text password storage.
    /// </summary>
    public static class SecurityUtil
    {
        /// <summary>
        /// Computes the SHA-256 hash for a given plain-text password.
        /// </summary>
        /// <param name="rawData">The plain-text password entered by the user.</param>
        /// <returns>A 64-character hexadecimal string representing the hashed password.</returns>
        /// <exception cref="ArgumentException">Thrown when the provided password string is null or empty.</exception>
        public static string ComputeSha256Hash(string rawData)
        {
            if (string.IsNullOrWhiteSpace(rawData))
            {
                throw new ArgumentException("Password input cannot be null or empty for hashing.", nameof(rawData));
            }

            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (CryptographicException ex)
            {
                throw new Exception("A critical error occurred during the encryption process.", ex);
            }
        }
    }
}