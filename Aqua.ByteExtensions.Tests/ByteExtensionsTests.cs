using System.Collections.Generic;
using Xunit;

namespace Aqua.ByteExtensions.Tests
{
    public class ByteExtensionsTests
    {
        [Theory]
        [MemberData(nameof(GetToBytesBooleanData()))]
        public void ToBytes_Boolean_Valid(byte[] expected, bool input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_Boolean_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesBooleanData()
        {
            return new List<object[]>
            {
                        new object[]{new byte[] {0}, null},
                        new object[]{new byte[] {1}, true},
                        new object[]{new byte[] {0}, false},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesCharData()))]
        public void ToBytes_Char_Valid(byte[] expected, char input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_Char_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesCharData()
        {
            return new List<object[]>
            {
                        new object[]{new byte[] {0, 0}, null},
                        new object[]{new byte[] {65, 0}, 'A'},
                        new object[]{new byte[] {48, 0}, '0'},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesDoubleData()))]
        public void ToBytes_Double_Valid(byte[] expected, double input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for tests - ToBytes_Double_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesDoubleData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0.0000000000000000E+000},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 240, 63 }, 1.0000000000000000E+000},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 224, 111, 64 }, 2.5500000000000000E+002},
                        new object[]{ new byte[] { 255, 255, 255, 255, 255,  255, 239, 255 }, -1.7976931348623157E+308},
                        new object[]{ new byte[] { 1, 0, 0, 0, 0, 0, 0, 0 }, 4.9406564584124654E-324},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesShortData()))]
        public void ToBytes_Short_Valid(byte[] expected, short input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_Short_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesShortData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0}, 0},
                        new object[]{ new byte[] { 15, 0 }, 15},
                        new object[]{ new byte[] { 241, 255 }, -15},
                        new object[]{ new byte[] { 0, 128 }, short.MinValue},
                        new object[]{ new byte[] { 255, 127 }, short.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesIntData()))]
        public void ToBytes_Int_Valid(byte[] expected, int input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_Int_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesIntData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 128 }, int.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 127 }, int.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesLongData()))]
        public void ToBytes_Long_Valid(byte[] expected, long input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_Long_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesLongData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 128 }, long.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255, 255, 255, 255, 127 }, long.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesFloatData()))]
        public void ToBytes_Float_Valid(byte[] expected, float input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_Float_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesFloatData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 255, 255, 127, 255 }, float.MinValue},
                        new object[]{ new byte[] { 255, 255, 127, 127 }, float.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesUshortData()))]
        public void ToBytes_UShort_Valid(byte[] expected, float input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_UShort_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesUshortData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0 }, ushort.MinValue},
                        new object[]{ new byte[] { 0, 255, 127, 71 }, ushort.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesUintData()))]
        public void ToBytes_UInt_Valid(byte[] expected, uint input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_UInt_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesUintData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0 }, uint.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255 }, uint.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesUlongData()))]
        public void ToBytes_ULong_Valid(byte[] expected, ulong input) => Assert.Equal(expected, input.ToBytes());

        /// <summary>
        /// Sample data for test - ToBytes_ULong_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesUlongData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, ulong.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 }, ulong.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesBooleanReversedData()))]
        public void ToBytes_BooleanReversed_Valid(byte[] expected, bool input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_BooleanReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesBooleanReversedData()
        {
            return new List<object[]>
            {
                        new object[]{new byte[] {0}, null},
                        new object[]{new byte[] {1}, true},
                        new object[]{new byte[] {0}, false},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesCharReversedData()))]
        public void ToBytes_CharReversed_Valid(byte[] expected, char input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_CharReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesCharReversedData()
        {
            return new List<object[]>
            {
                        new object[]{new byte[] {0, 0}, null},
                        new object[]{new byte[] {0, 65}, 'A'},
                        new object[]{new byte[] {0, 48}, '0'},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesDoubleReversedData()))]
        public void ToBytes_DoubleReversed_Valid(byte[] expected, double input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_DoubleReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesDoubleReversedData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0.0000000000000000E+000},
                        new object[]{ new byte[] { 63, 240, 0, 0, 0, 0, 0, 0 }, 1.0000000000000000E+000},
                        new object[]{ new byte[] { 64, 111, 224, 0, 0, 0, 0, 0}, 2.5500000000000000E+002},
                        new object[]{ new byte[] { 255, 239, 255, 255, 255,  255, 255, 255 }, -1.7976931348623157E+308},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 1 }, 4.9406564584124654E-324},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesShortReversedData()))]
        public void ToBytes_ShortReversed_Valid(byte[] expected, short input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_ShortReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesShortReversedData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0}, 0},
                        new object[]{ new byte[] { 0, 15 }, 15},
                        new object[]{ new byte[] { 255, 241 }, -15},
                        new object[]{ new byte[] { 128, 0 }, short.MinValue},
                        new object[]{ new byte[] { 127, 255 }, short.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesIntReversedData()))]
        public void ToBytes_IntReversed_Valid(byte[] expected, int input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_ShortReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesIntReversedData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 128, 0, 0, 0 }, int.MinValue},
                        new object[]{ new byte[] { 127, 255, 255, 255 }, int.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesLongReversedData()))]
        public void ToBytes_LongReversed_Valid(byte[] expected, long input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_LongReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesLongReversedData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 128, 0, 0, 0, 0, 0, 0, 0 }, long.MinValue},
                        new object[]{ new byte[] { 127, 255, 255, 255, 255, 255, 255, 255 }, long.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesFloatReversedData()))]
        public void ToBytes_FloatReversed_Valid(byte[] expected, float input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_FloatReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesFloatReversedData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 255, 127, 255, 255 }, float.MinValue},
                        new object[]{ new byte[] { 127, 127, 255, 255 }, float.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesUshortReversedData()))]
        public void ToBytes_UShortReversed_Valid(byte[] expected, float input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_UShortReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesUshortReversedData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0 }, ushort.MinValue},
                        new object[]{ new byte[] { 71, 127, 255, 0 }, ushort.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesUintReversedData()))]
        public void ToBytes_UIntReversed_Valid(byte[] expected, uint input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_UIntReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesUintReversedData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0 }, uint.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255 }, uint.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(GetToBytesUlongReversedData()))]
        public void ToBytes_ULongReversed_Valid(byte[] expected, ulong input) => Assert.Equal(expected, input.ToBytesReversed());

        /// <summary>
        /// Sample data for test - ToBytes_ULongReversed_Valid
        /// </summary>
        public static IEnumerable<object[]> GetToBytesUlongReversedData()
        {
            return new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 }, ulong.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 255, 255, 255, 255, 255 }, ulong.MaxValue},
            };
        }

        [Theory]
        [MemberData(nameof(ToBytesBigEndianData))]
        public void ToBytesBigEndian_Valid(byte[] expected, int input) => Assert.Equal(expected, input.ToBytesBigEndian());

        /// <summary>
        /// Sample data for test - ToBytesBigEndian_Valid
        /// </summary>
        public static IEnumerable<object[]> ToBytesBigEndianData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 128, 0, 0, 0 }, int.MinValue},
                        new object[]{ new byte[] { 127, 255, 255, 255 }, int.MaxValue},
            };

        [Theory]
        [MemberData(nameof(ToBytesLittleEndianData))]
        public void ToBytesLittleEndian_Valid(byte[] expected, int input) => Assert.Equal(expected, input.ToBytesLittleEndian());

        /// <summary>
        /// Sample data for test - ToBytesLittleEndian_Valid
        /// </summary>
        public static IEnumerable<object[]> ToBytesLittleEndianData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 0, 0, 0, 0 }, 0},
                        new object[]{ new byte[] { 0, 0, 0, 128 }, int.MinValue},
                        new object[]{ new byte[] { 255, 255, 255, 127 }, int.MaxValue},
            };

        [Theory]
        [MemberData(nameof(GetBytesAtData))]
        public void GetBytesAt_Valid(byte[] expected, byte[] input, int at, int n) => Assert.Equal(expected, input.GetBytesAt(at, n));

        /// <summary>
        /// Sample data for test - GetBytesAt_Valid
        /// </summary>
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
        public void Append_Valid(byte[] expected, byte[] input, byte[] newBytes) => Assert.Equal(expected, input.Append(newBytes));

        /// <summary>
        /// Sample data for test - Append_Valid
        /// </summary>
        public static IEnumerable<object[]> AppendData =>
            new List<object[]>
            {
                        new object[]{ new byte[] { 255 }, null , new byte[] { 255 }},
                        new object[]{ new byte[] { 255 }, new byte[] { }, new byte[] { 255 }},
                        new object[]{ new byte[] { 255, 127, 127 }, new byte[] { 255, 127 },  new byte[] { 127 }},
            };

        [Theory]
        [MemberData(nameof(InsertData))]
        public void Insert_Valid(byte[] expected, byte[] input, byte[] newBytes, int at) => Assert.Equal(expected, input.Insert(newBytes, at));

        /// <summary>
        /// Sample data for test - Insert_Valid
        /// </summary>
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
        public void Remove_Valid(byte[] expected, byte[] input, int at, int n) => Assert.Equal(expected, input.Remove(at, n));

        /// <summary>
        /// Sample data for test - Remove_Valid
        /// </summary>
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
        public void ToHexString_Valid(string expected, byte[] input) => Assert.Equal(expected, input.ToHexString());

        /// <summary>
        /// Sample data for test - ToHexString_Valid
        /// </summary>
        public static IEnumerable<object[]> ToHexStringData =>
            new List<object[]>
            {
                        new object[]{ "", null},
                        new object[]{ "", new byte[] { }},
                        new object[]{ "01-02-04-08-10-20", new byte[] { 1, 2, 4, 8, 16, 32 } }
            };

        [Theory]
        [MemberData(nameof(ToHexStringDashFreeData))]
        public void ToHexStringDashFree_Valid(string expected, byte[] input) => Assert.Equal(expected, input.ToHexStringDashFree());

        /// <summary>
        /// Sample data for test - ToHexStringDashFree_Valid
        /// </summary>
        public static IEnumerable<object[]> ToHexStringDashFreeData =>
            new List<object[]>
            {
                        new object[]{ "", null},
                        new object[]{ "", new byte[] { }},
                        new object[]{ "010204081020", new byte[] { 1, 2, 4, 8, 16, 32 } }
            };

        [Theory]
        [MemberData(nameof(ToHexStringBase64Data))]
        public void ToHexStringBase64_Valid(string expected, byte[] input) => Assert.Equal(expected, input.ToHexStringBase64());

        /// <summary>
        /// Sample data for test - ToHexStringBase64_Valid
        /// </summary>
        public static IEnumerable<object[]> ToHexStringBase64Data =>
            new List<object[]>
            {
                        new object[]{ "", null},
                        new object[]{ "", new byte[] { }},
                        new object[]{ "AQIECBAg", new byte[] { 1, 2, 4, 8, 16, 32 } }
            };

        [Theory]
        [MemberData(nameof(IsHexStringData))]
        public void IsHexString_Valid(bool expected, string input) => Assert.Equal(expected, input.IsHexString());

        /// <summary>
        /// Sample data for test - IsHexString_Valid
        /// </summary>
        public static IEnumerable<object[]> IsHexStringData =>
            new List<object[]>
            {
                        new object[]{ false, null},
                        new object[]{ true, "010204081020"},
                        new object[]{ false, "Z1-02-04-08-10-20" }
            };

        [Theory]
        [MemberData(nameof(IsHexStringCStyleData))]
        public void IsHexStringCStyle_Valid(bool expected, string input) => Assert.Equal(expected, input.IsHexStringCStyle());

        /// <summary>
        /// Sample data for test - IsHexStringCStyle_Valid
        /// </summary>
        public static IEnumerable<object[]> IsHexStringCStyleData =>
            new List<object[]>
            {
                        new object[]{ false, null},
                        new object[]{ true, "0x64"},
                        new object[]{ false, "0y64" }
            };

        [Theory]
        [MemberData(nameof(GetBytes_Base64Data))]
        public void GetBytes_Base64_Valid(byte[] expected, string input) => Assert.Equal(expected, input.GetBytes());

        /// <summary>
        /// Sample data for test - GetBytes_Base64_Valid
        /// </summary> 
        public static IEnumerable<object[]> GetBytes_Base64Data =>
            new List<object[]>
            {
                        new object[]{ new byte[] { }, null},
                        new object[]{ new byte[] { 1, 2, 4, 8, 16, 32 }, "AQIECBAg"},
            };

    }
}
