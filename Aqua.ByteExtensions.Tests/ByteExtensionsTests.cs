using System.Collections.Generic;
using Xunit;

namespace Aqua.ByteExtensions.Tests
{
    public class ByteExtensionsTests
    {
        [Theory]
        [MemberData(nameof(ToBytesBooleanData))]
        public void ToBytes_Boolean_Valid(byte[] expected, bool input)
        {
            Assert.Equal(expected, input.ToBytes());
        }

        public static IEnumerable<object[]> ToBytesBooleanData =>
            new List<object[]>
            {
                        new object[]{new byte[] {0}, null},
                        new object[]{new byte[] {1}, true},
                        new object[]{new byte[] {0}, false},
            };

        [Theory]
        [MemberData(nameof(ToBytesCharData))]
        public void ToBytes_Char_Valid(byte[] expected, char input)
        {
            Assert.Equal(expected, input.ToBytes());
        }

        public static IEnumerable<object[]> ToBytesCharData =>
            new List<object[]>
            {
                        new object[]{new byte[] {0, 0}, null},
                        new object[]{new byte[] {65, 0}, 'A'},
                        new object[]{new byte[] {48, 0}, '0'},
            };

        [Theory]
        [MemberData(nameof(ToBytesDoubleData))]
        public void ToBytes_Double_Valid(byte[] expected, double input)
        {
            Assert.Equal(expected, input.ToBytes());

        }

        public static IEnumerable<object[]> ToBytesDoubleData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0.0000000000000000E+000},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 240, 63 }, 1.0000000000000000E+000},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 224, 111, 64 }, 2.5500000000000000E+002},
                        new object[]{ new byte[] { 255, 255, 255, 255, 255,  255, 239, 255 }, -1.7976931348623157E+308},
                        new object[]{ new byte[] { 1, 0, 0, 0, 0, 0, 0, 0 }, 4.9406564584124654E-324},
            };

        [Theory]
        [MemberData(nameof(ToBytesShortData))]
        public void ToBytes_Short_Valid(byte[] expected, short input)
        {
            Assert.Equal(expected, input.ToBytes());

        }

        public static IEnumerable<object[]> ToBytesShortData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0}, 0},
                        new object[]{ new byte[] { 15, 0 }, 15},
                        new object[]{ new byte[] { 241, 255 }, -15},
                        new object[]{ new byte[] { 0, 128 }, short.MinValue},
                        new object[]{ new byte[] { 255, 127 }, short.MaxValue},
            };

    }
}
