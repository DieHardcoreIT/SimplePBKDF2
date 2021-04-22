using System;
using System.Security.Cryptography;
using System.Text;

namespace SimplePBKDF2
{
    public static class Pbkdf2
    {
        /// <summary>
        /// Hash the specify string with the salt.
        /// </summary>
        /// <param name="plaintext">Text (or password) that should be hashed.</param>
        /// <param name="salt">The previously generated salt.</param>
        /// <param name="iterations"></param>
        /// <returns>The hashed text (or password).</returns>
        public static string Hash(string plaintext, string salt, int iterations = 100000)
        {
            if (string.IsNullOrWhiteSpace(plaintext)) throw new ArgumentNullException(nameof(plaintext));
            if (string.IsNullOrWhiteSpace(salt)) throw new ArgumentNullException(nameof(salt));
            if (iterations <= 0) throw new ArgumentException("Iterations cannot be less than 1.");

            var saltBytes = Encoding.UTF8.GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(plaintext, saltBytes, iterations);

            var hashedBytes = pbkdf2.GetBytes(64);

            var hashed = Convert.ToBase64String(hashedBytes);

            return hashed;
        }

        /// <summary>
        /// Generates a random password with a secure random number generator.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GeneratePassword(int length = 30)
        {
            if (length <= 0)
                throw new ArgumentException(
                    "Cannot generate a password because it has to be longer than 0 characters.");

            return GenerateRandomString(length);
        }

        /// <summary>
        /// Generates a random salt with a secure random number generator.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateSalt(int length = 64)
        {
            if (length <= 0)
                throw new InvalidOperationException(
                    "Cannot generate a salt because it has to be longer than 0 characters.");

            return GenerateRandomString(length);
        }


        private static string GenerateRandomString(int length,
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890+-*{}&_!?/%")
        {
            using (var crypto = new RNGCryptoServiceProvider())
            {
                var data = new byte[length];

                // If chars.Length isn't a power of 2 then there is a bias if we simply use the modulus operator. The first characters of chars will be more probable than the last ones.
                // buffer used if we encounter an unusable random byte. We will regenerate it in this buffer
                byte[] buffer = null;

                // Maximum random number that can be used without introducing a bias
                var maxRandom = byte.MaxValue - (byte.MaxValue + 1) % chars.Length;

                crypto.GetBytes(data);

                var result = new char[length];

                for (var i = 0; i < length; i++)
                {
                    var value = data[i];

                    while (value > maxRandom)
                    {
                        if (buffer == null) buffer = new byte[1];

                        crypto.GetBytes(buffer);
                        value = buffer[0];
                    }

                    result[i] = chars[value % chars.Length];
                }

                return new string(result);
            }
        }
    }
}