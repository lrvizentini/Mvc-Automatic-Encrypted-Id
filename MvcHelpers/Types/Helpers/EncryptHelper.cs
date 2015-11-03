using System;
using System.Text.RegularExpressions;

namespace MvcHelpers.Types.Helpers
{
    public class EncryptHelper
    {
        public static string Encrypt(int value)
        {
            return Normalize(Convert.ToBase64String(BitConverter.GetBytes(value)).Replace("==", ""));
        }
        public static string Encrypt(long value)
        {
            return Normalize(Convert.ToBase64String(BitConverter.GetBytes(value)).Replace("==", ""));
        }

        public static int Decrypt(string value)
        {
            value = value.EndsWith("=") ? value : value + "==";
            return BitConverter.ToInt32(Convert.FromBase64String(UnNormalize(value)), 0);
        }
        public static long DecryptToLong(string value)
        {
            value = value.EndsWith("=") ? value : value + "==";
            return BitConverter.ToInt64(Convert.FromBase64String(UnNormalize(value)), 0);
        }

        private static string Normalize(string value)
        {
            value = Regex.Replace(value, @"\/", "|");
            return value;
        }

        private static string UnNormalize(string value)
        {
            value = Regex.Replace(value, @"\|", "/");
            return value;
        }

    }
}