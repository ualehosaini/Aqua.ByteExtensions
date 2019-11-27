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

    }
}
