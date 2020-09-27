using System;

namespace Aqua.ByteExtensions
{
    public static class ByteExtensions
    {
        /// <summary>
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this bool input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this char input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this double input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this short input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this int input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this long input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this ushort input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns reversed byte array
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
        /// Returns reversed byte array
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
        /// Returns reversed byte array
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
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this float input)
        {
            return BitConverter.GetBytes(input);
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
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this uint input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this ulong input)
        {
            return BitConverter.GetBytes(input);
        }

        /// <summary>
        /// Returns reversed byte array
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
        /// Returns reversed byte array
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
        /// Returns reversed byte array
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] ToBytesReversed(this long input)
        {
            byte[] result = BitConverter.GetBytes(input);

            Array.Reverse(result);

            return result;
        }


    }
}
