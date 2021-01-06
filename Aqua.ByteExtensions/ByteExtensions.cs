using System;

namespace Aqua.ByteExtensions
{
    public static class ByteExtensions
    {
        /// <summary>
        /// Returns byte array from bool
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this bool input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from char
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this char input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from double
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this double input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from short
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this short input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this int input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from long
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this long input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from ushort
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this ushort input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from float
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this float input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from uint
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this uint input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns byte array from ulong
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this ulong input) => BitConverter.GetBytes(input);

        /// <summary>
        /// Returns reversed byte array from bool
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this bool input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from char
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this char input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from double
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this double input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from short
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this short input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this int input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from long
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this long input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from float
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this float input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from ushort
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this ushort input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from uint
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this uint input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns reversed byte array from ulong
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this ulong input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }

        /// <summary>
        /// Returns Big Endian byte array from int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesBigEndian(this int input)
        {
            byte[] result = BitConverter.GetBytes(input);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(result);
            return result;
        }

        /// <summary>
        /// Returns Little Endian byte array from int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesLittleEndian(this int input)
        {
            byte[] result = BitConverter.GetBytes(input);
            if (!BitConverter.IsLittleEndian)
                Array.Reverse(result);
            return result;
        }

        /// <summary>
        /// Return Sub Bytes of a Byte Array
        /// </summary>
        /// <param name="input"></param>
        /// <param name="at"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static byte[] GetBytesAt(this byte[] input, int at, int n)
        {
            if (input == null || input.Length == 0 || n < 1 || at < 0 || at > input.Length)
                return new byte[] { };

            var resultLength = at + n > input.Length ? input.Length - at : n;
            var result = new byte[resultLength];
            Buffer.BlockCopy(input, at, result, 0, resultLength);
            return result;

        }

        /// <summary>
        /// Append bytes at the end
        /// </summary>
        /// <param name="input"></param>
        /// <param name="newBytes"></param>
        /// <returns></returns>
        public static byte[] Append(this byte[] input, byte[] newBytes)
        {
            if (input == null && newBytes == null)
                return new byte[] { };

            if (input == null)
                return newBytes;

            if (newBytes == null)
                return input;

            var result = new byte[input.Length + newBytes.Length];
            Array.Copy(input, result, input.Length);
            Array.Copy(newBytes, 0, result, input.Length, newBytes.Length);

            return result;
        }

        /// <summary>
        /// Insert bytes at a specified location
        /// </summary>
        /// <param name="input"></param>
        /// <param name="newBytes"></param>
        /// <param name="at"></param>
        /// <returns></returns>
        public static byte[] Insert(this byte[] input, byte[] newBytes, int at)
        {
            if (input == null && newBytes == null)
            {
                return null;
            }

            if ((input == null || input.Length == 0) && newBytes != null)
            {
                return newBytes;
            }

            if ((input.Length == 0) && (newBytes == null || newBytes.Length == 0))
            {
                return input;
            }

            int tempAt = at > input.Length ? input.Length : at;

            byte[] bytes = new byte[input.Length + newBytes.Length];
            Buffer.BlockCopy(input, 0, bytes, 0, tempAt);
            Buffer.BlockCopy(newBytes, 0, bytes, tempAt, newBytes.Length);
            Buffer.BlockCopy(input, tempAt, bytes, tempAt + newBytes.Length, input.Length - tempAt);

            return bytes;
        }

        /// <summary>
        /// Remove bytes at a specific location
        /// </summary>
        /// <param name="input"></param>
        /// <param name="at"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] Remove(this byte[] input, int at, int n)
        {
            if (input == null)
            {
                return null;
            }

            if (input.Length == 0)
            {
                return new byte[] { };
            }

            if (at < 0 || at > input.Length || n < 1)
            {
                return input;
            }

            byte[] result;
            if (at + n > input.Length)
            {
                var subLength = input.Length - at;
                result = new byte[subLength];
                Buffer.BlockCopy(input, 0, result, 0, subLength);
            }
            else
            {
                result = new byte[input.Length - n];
                Buffer.BlockCopy(input, 0, result, 0, at);
                Buffer.BlockCopy(input, at + n, result, at, input.Length - at - n);

            }
            return result;
        }

        /// <summary>
        /// Returns Hex String of Byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToHexString(this byte[] input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;

            return BitConverter.ToString(input);
        }

        /// <summary>
        /// Returns a Dash (-) Free Hex String of Byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToHexStringDashFree(this byte[] input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;

            return BitConverter.ToString(input).Replace("-", string.Empty);
        }

        /// <summary>
        /// Returns a Base64 String of Byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToHexStringBase64(this byte[] input)
        {
            if (input == null || input.Length == 0)
                return string.Empty;

            return Convert.ToBase64String(input);
        }

        /// <summary>
        /// Validate a string if it is Base64
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsBase64(this string input)
        {
            if (string.IsNullOrEmpty(input)
               || input.Length % 4 != 0
               || input.Contains(" ")
               || input.Contains("\t")
               || input.Contains("\r")
               || input.Contains("\n"))
                return false;

            try
            {
                Convert.FromBase64String(input);
                return true;
            }
            catch
            {
                // Handle the exception
            }

            return false;
        }

        /// <summary>
        /// Validate if a string is Hex String
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsHexString(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return System.Text.RegularExpressions.Regex.IsMatch(input, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        /// <summary>
        /// Validate if a string is a C-Style Hex String
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsHexStringCStyle(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return System.Text.RegularExpressions.Regex.IsMatch(input, @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z");
        }

        /// <summary>
        /// Get Byte Array from a Hex String
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] GetBytes(this string input) 
            => input.IsBase64() 
            ? Convert.FromBase64String(input) 
            : (new byte[] { });
    }
}
