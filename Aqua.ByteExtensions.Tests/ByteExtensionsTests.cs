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

        [Theory]
        [MemberData(nameof(ToBytesIntData))]
        public void ToBytes_Int_Valid(byte[] expected, int input)
        {
            Assert.Equal(expected, input.ToBytes());
        }

        public static IEnumerable<object[]> ToBytesIntData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 128 }, int.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 127 }, int.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesBooleanReversedData))]
        public void ToBytes_BooleanReversed_Valid(byte[] expected, bool input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesBooleanReversedData =>
            new List<object[]>
            {
                        new object[]{new byte[] {0}, null},
                        new object[]{new byte[] {1}, true},
                        new object[]{new byte[] {0}, false},
            };


        [Theory]
        [MemberData(nameof(ToBytesCharReversedData))]
        public void ToBytes_CharReversed_Valid(byte[] expected, char input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesCharReversedData =>
            new List<object[]>
            {
                        new object[]{new byte[] {0, 0}, null},
                        new object[]{new byte[] {0, 65}, 'A'},
                        new object[]{new byte[] {0, 48}, '0'},
            };

        [Theory]
        [MemberData(nameof(ToBytesLongData))]
        public void ToBytes_Long_Valid(byte[] expected, long input)
        {
            Assert.Equal(expected, input.ToBytes());
        }

        public static IEnumerable<object[]> ToBytesLongData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 128 }, long.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255, 255, 255, 255, 127 }, long.MaxValue},
            };


        [Theory]
        [MemberData(nameof(ToBytesDoubleReversedData))]
        public void ToBytes_DoubleReversed_Valid(byte[] expected, double input)
        {
            Assert.Equal(expected, input.ToBytesReversed());

        }

        public static IEnumerable<object[]> ToBytesDoubleReversedData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0.0000000000000000E+000},
                        new object[]{ new byte[] { 63, 240, 0, 0, 0, 0, 0, 0 }, 1.0000000000000000E+000},
                        new object[]{ new byte[] { 64, 111, 224, 0, 0, 0, 0, 0}, 2.5500000000000000E+002},
                        new object[]{ new byte[] { 255, 239, 255, 255, 255,  255, 255, 255 }, -1.7976931348623157E+308},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 }, 4.9406564584124654E-324},
            };

        [Theory]
        [MemberData(nameof(ToBytesFloatData))]
        public void ToBytes_Float_Valid(byte[] expected, float input)
        {
            Assert.Equal(expected, input.ToBytes());
        }

        public static IEnumerable<object[]> ToBytesFloatData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 255, 255, 127, 255 }, float.MinValue},
                        new object[]{ new byte[] { 255, 255, 127, 127 }, float.MaxValue},
            };

        [Theory]
        [MemberData(nameof(GetBytesAtData))]
        public void GetBytesAt_Valid(byte[] expected, byte[] input, int at, int n)
        {
            Assert.Equal(expected, input.GetBytesAt(at, n));
        }

        public static IEnumerable<object[]> GetBytesAtData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { }, null , 3, 2},
                        new object[]{ new byte[] { }, new byte[] { 255 }, 3, -1},
                        new object[]{ new byte[] { }, new byte[] { 255 }, 3, 2},
                        new object[]{ new byte[] { }, new byte[] { 255 }, -3, 2},
                        new object[]{ new byte[] { 255, 127 }, new byte[] { 255, 255, 255, 127 },  2, 2},
                        new object[]{ new byte[] { 128 }, new byte[] { 0, 0, 0, 128 }, 3, 2},
                        new object[]{ new byte[] { 255, 127 }, new byte[] { 255, 255, 255, 127 },  2, 2},
            };

        [Theory]
        [MemberData(nameof(ToBytesUshortData))]
        public void ToBytes_UShort_Valid(byte[] expected, float input)
        {
            Assert.Equal(expected, input.ToBytes());
        }

        public static IEnumerable<object[]> ToBytesUshortData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0 }, ushort.MinValue},
                        new object[]{ new byte[] { 0, 255, 127, 71 }, ushort.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesUintData))]
        public void ToBytes_UInt_Valid(byte[] expected, uint input)
        {
            Assert.Equal(expected, input.ToBytes());
        }

        public static IEnumerable<object[]> ToBytesUintData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0 }, uint.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255 }, uint.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesUlongData))]
        public void ToBytes_ULong_Valid(byte[] expected, ulong input)
        {
            Assert.Equal(expected, input.ToBytes());
        }

        public static IEnumerable<object[]> ToBytesUlongData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, ulong.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 }, ulong.MaxValue},
            };
    }
}
