namespace CultureGR_MVC_ModelFirst.Security
{
    public static class EncryptionUtil
    {
        public static string Encrypt(string plainText)
        {
            var encryptedPassword = BCrypt.Net.BCrypt.HashPassword(plainText);
            return encryptedPassword;
        }

        public static bool IsValidPassword(string plainText, string encryptedText)
        {
            return BCrypt.Net.BCrypt.Verify(plainText, encryptedText);
        }
    }
}
