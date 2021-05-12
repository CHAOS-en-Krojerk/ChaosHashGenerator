using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SHA3.Net;

namespace RetHashFuncs
{
    public class HashingHandler
    {
        public static string ComputeHashAsBytesString(string textToHash, int method)
        {
            string result = "";
            // Create a SHA256
            switch (method)
            {
                case 0:
                    {
                        using (MD5 md5Hash = MD5.Create())
                        {
                            var inputInBytes = Encoding.UTF8.GetBytes(textToHash);
                            byte[] bytes = md5Hash.ComputeHash(inputInBytes);
                            result = DisplayBytesAsString(bytes);
                        }
                    }
                    break;
                case 1:
                    {
                        using (SHA1 sha1Hash = SHA1.Create())
                        {
                            var inputInBytes = Encoding.UTF8.GetBytes(textToHash);
                            byte[] bytes = sha1Hash.ComputeHash(inputInBytes);
                            result = DisplayBytesAsString(bytes);
                        }
                    }
                    break;
                case 2:
                    {
                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            var inputInBytes = Encoding.UTF8.GetBytes(textToHash);
                            byte[] bytes = sha256Hash.ComputeHash(inputInBytes);
                            result = DisplayBytesAsString(bytes);
                        }
                    }
                    break;
                case 3:
                    {
                        using (SHA512 sHA512Hash = SHA512.Create())
                        {
                            var inputInBytes = Encoding.UTF8.GetBytes(textToHash);
                            byte[] bytes = sHA512Hash.ComputeHash(inputInBytes);
                            result = DisplayBytesAsString(bytes);
                        }
                    }
                    break;
                case 4:
                    {
                        using (var sha3_256Hash = Sha3.Sha3256())
                        {
                            var inputInBytes = Encoding.UTF8.GetBytes(textToHash);
                            byte[] bytes = sha3_256Hash.ComputeHash(inputInBytes);
                            result = DisplayBytesAsString(bytes);
                        }
                    }
                    break;
                case 5:
                    {
                        using (var sha3_512Hash = Sha3.Sha3512())
                        {
                            var inputInBytes = Encoding.UTF8.GetBytes(textToHash);
                            byte[] bytes = sha3_512Hash.ComputeHash(inputInBytes);
                            result = DisplayBytesAsString(bytes);
                        }
                    }
                    break;
            }
            return result.Replace(" ", string.Empty);
        }

        public static string ComputeHashAsBytesFile(string fileName, int method)
        {
            if (fileName == "")
            {
                throw new IOException("Are you sure you chose a file?");
            }
            string result = "";
            using (FileStream fileStream = File.OpenRead(fileName))
            {
                switch (method)
                {
                    case 0:
                        {
                            using (MD5 md5Hash = MD5.Create())
                            {
                                byte[] hashValue = md5Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                    case 1:
                        {
                            using (SHA1 sha1Hash = SHA1.Create())
                            {
                                byte[] hashValue = sha1Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                    case 2:
                        {
                            using (SHA256 sha256Hash = SHA256.Create())
                            {
                                byte[] hashValue = sha256Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                    case 3:
                        {
                            using (SHA512 sha512Hash = SHA512.Create())
                            {
                                byte[] hashValue = sha512Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                    case 4:
                        {
                            using (var sha3_256Hash = Sha3.Sha3256())
                            {
                                byte[] hashValue = sha3_256Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                    case 5:
                        {
                            using (var sha3_512Hash = Sha3.Sha3512())
                            {
                                byte[] hashValue = sha3_512Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;

                }
            }
            return result.Replace(" ", string.Empty);
        }

        public static string ComputeHMACHashAsBytesFile(byte[] key, string fileName, int method)
        {
            if (key == null)
            {
                throw new ArgumentNullException("Are you sure you generated a random key?");
            }
            if (fileName == "")
            {
                throw new IOException("Are you sure you chose a file?");
            }

            string result = "";
            using (FileStream fileStream = File.OpenRead(fileName))
            {
                switch (method)
                {
                    case 0:
                        {
                            using (HMACMD5 md5Hash = new HMACMD5(key))
                            {
                                byte[] hashValue = md5Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                    case 1:
                        {
                            using (HMACSHA1 sha1Hash = new HMACSHA1(key))
                            {
                                byte[] hashValue = sha1Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                    case 2:
                        {
                            using(HMACSHA256 sha256Hash = new HMACSHA256(key))
                            {
                                byte[] hashValue = sha256Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                    case 3:
                        {
                            using(HMACSHA512 sha512Hash = new HMACSHA512(key))
                            {
                                byte[] hashValue = sha512Hash.ComputeHash(fileStream);
                                result = DisplayBytesAsString(hashValue);
                            }
                        }
                        break;
                }
            }
            return result.Replace(" ", string.Empty);
        }

        public static string DisplayBytesAsString(byte[] bytesToDiplay)
        {
            string retval = "";
            foreach (var bytes in bytesToDiplay)
            {
                retval += " " + bytes.ToString("x2");
            }
            retval = retval.Trim();
            return retval;
        }

        public static byte[] ParseDisplayedBytes(string bytesInString)
        {
            var bytesInStringParts = SplitInParts(bytesInString, 2);
            bytesInString = string.Join(" ", bytesInStringParts);
            string[] bytesInStringArray = bytesInString.Split(' ');
            var len = bytesInStringArray.Length;
            byte[] bytes = new byte[len];

            for (int i = 0; i < len; i++)
            {
                bytes[i] = Convert.ToByte(bytesInStringArray[i], 16); //Base 16 - hex.
            }
            return bytes;
        }

        public static IEnumerable<string> SplitInParts(string s, int partLength)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }

        public static byte[] GenerateRandomKey()
        {
            byte[] randomKey = new byte[64];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomKey);
            }
            return randomKey;
        }
    }
}
