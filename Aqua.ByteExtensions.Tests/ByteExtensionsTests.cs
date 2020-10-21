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
        [MemberData(nameof(ToBytesShortReversedData))]
        public void ToBytes_ShortReversed_Valid(byte[] expected, short input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesShortReversedData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0}, 0},
                        new object[]{ new byte[] { 0, 15 }, 15},
                        new object[]{ new byte[] { 255, 241 }, -15},
                        new object[]{ new byte[] { 128, 0 }, short.MinValue},
                        new object[]{ new byte[] { 127, 255 }, short.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesIntReversedData))]
        public void ToBytes_IntReversed_Valid(byte[] expected, int input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesIntReversedData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 128, 0, 0, 0 }, int.MinValue},
                        new object[]{ new byte[] { 127, 255, 255, 255 }, int.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesLongReversedData))]
        public void ToBytes_LongReversed_Valid(byte[] expected, long input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesLongReversedData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 128, 0, 0, 0, 0, 0, 0, 0 }, long.MinValue},
                        new object[]{ new byte[] { 127, 255, 255, 255, 255, 255, 255, 255 }, long.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesFloatReversedData))]
        public void ToBytes_FloatReversed_Valid(byte[] expected, float input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesFloatReversedData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 255, 127, 255, 255 }, float.MinValue},
                        new object[]{ new byte[] { 127, 127, 255, 255 }, float.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesUshortReversedData))]
        public void ToBytes_UShortReversed_Valid(byte[] expected, float input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesUshortReversedData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0 }, ushort.MinValue},
                        new object[]{ new byte[] { 71, 127, 255, 0 }, ushort.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesUintReversedData))]
        public void ToBytes_UIntReversed_Valid(byte[] expected, uint input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesUintReversedData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0 }, uint.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255 }, uint.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesUlongReversedData))]
        public void ToBytes_ULongReversed_Valid(byte[] expected, ulong input)
        {
            Assert.Equal(expected, input.ToBytesReversed());
        }

        public static IEnumerable<object[]> ToBytesUlongReversedData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, ulong.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 }, ulong.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesBigEndianData))]
        public void ToBytesBigEndian_Valid(byte[] expected, int input)
        {
            Assert.Equal(expected, input.ToBytesBigEndian());
        }

        public static IEnumerable<object[]> ToBytesBigEndianData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 128, 0, 0, 0 }, int.MinValue},
                        new object[]{ new byte[] { 127, 255, 255, 255 }, int.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesLittleEndianData))]
        public void ToBytesLittleEndian_Valid(byte[] expected, int input)
        {
            Assert.Equal(expected, input.ToBytesLittleEndian());
        }

        public static IEnumerable<object[]> ToBytesLittleEndianData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 128 }, int.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 127 }, int.MaxValue},
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
        [MemberData(nameof(AppendData))]
        public void Append_Valid(byte[] expected, byte[] input, byte[] newBytes)
        {
            Assert.Equal(expected, input.Append(newBytes));
        }

        public static IEnumerable<object[]> AppendData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 255 }, null , new byte[] { 255 }},
                        new object[]{ new byte[] { 255 }, new byte[] { }, new byte[] { 255 }},
                        new object[]{ new byte[] { 255, 127, 127 }, new byte[] { 255, 127 },  new byte[] { 127 }},
            };

        [Theory]
        [MemberData(nameof(InsertData))]
        public void Insert_Valid(byte[] expected, byte[] input, byte[] newBytes, int at)
        {
            Assert.Equal(expected, input.Insert(newBytes, at));
        }

        public static IEnumerable<object[]> InsertData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 255 }, null , new byte[] { 255 }, 0},
                        new object[]{ new byte[] { 255 }, new byte[] { }, new byte[] { 255 },0},
                        new object[]{ new byte[] { 255, 127, 127, 91}, new byte[] { 255, 127, 91 },  new byte[] { 127 }, 2},
                        new object[]{ new byte[] { 255, 127, 91, 127}, new byte[] { 255, 127, 91 },  new byte[] { 127 }, 10},
            };


        [Theory]
        [MemberData(nameof(RemoveData))]
        public void Remove_Valid(byte[] expected, byte[] input, int at, int n)
        {
            Assert.Equal(expected, input.Remove(at, n));
        }

        public static IEnumerable<object[]> RemoveData =>
            new List<object[]>
            {
                        new object[]{ null, null , 1, 0},
                        new object[]{ new byte[] { }, new byte[] { }, 1, 1},
                        new object[]{ new byte[] { 255 }, new byte[] { 255, 255 }, 1, 1},
                        new object[]{ new byte[] { 255, 127 }, new byte[] { 255, 127, 91 },  2, 1},
                        new object[]{ new byte[] { 255, 127, 91, 91, 127 }, new byte[] { 255, 127, 91, 255, 127, 91, 127 },  3, 2},
            };

        [Theory]
        [MemberData(nameof(ToHexStringData))]
        public void ToHexString_Valid(string expected, byte[] input)
        {
            Assert.Equal(expected, input.ToHexString());
        }

        public static IEnumerable<object[]> ToHexStringData =>
            new List<object[]>
            {
                        new object[]{ "", null},
                        new object[]{ "", new byte[] { }},
                        new object[]{ "01-02-04-08-10-20", new byte[] { 1, 2, 4, 8, 16, 32 } }
            };

        [Theory]
        [MemberData(nameof(ToHexStringDashFreeData))]
        public void ToHexStringDashFree_Valid(string expected, byte[] input)
        {
            Assert.Equal(expected, input.ToHexStringDashFree());
        }

        public static IEnumerable<object[]> ToHexStringDashFreeData =>
            new List<object[]>
            {
                        new object[]{ "", null},
                        new object[]{ "", new byte[] { }},
                        new object[]{ "010204081020", new byte[] { 1, 2, 4, 8, 16, 32 } }
            };

        [Theory]
        [MemberData(nameof(ToHexStringBase64Data))]
        public void ToHexStringBase64_Valid(string expected, byte[] input)
        {
            Assert.Equal(expected, input.ToHexStringBase64());
        }

        public static IEnumerable<object[]> ToHexStringBase64Data =>
            new List<object[]>
            {
                        new object[]{ "", null},
                        new object[]{ "", new byte[] { }},
                        new object[]{ "AQIECBAg", new byte[] { 1, 2, 4, 8, 16, 32 } }
            };

        [Theory]
        [MemberData(nameof(IsHexStringData))]
        public void IsHexString_Valid(bool expected, string input)
        {
            Assert.Equal(expected, input.IsHexString());
        }

        public static IEnumerable<object[]> IsHexStringData =>
            new List<object[]>
            {
                        new object[]{ false, null},
                        new object[]{ true, "010204081020"},
                        new object[]{ false, "Z1-02-04-08-10-20" }
            };



    }
}
