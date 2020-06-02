using SD_15_JOINING_INTS;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Theory]
        [InlineData(new uint[] { 2, 22, 3, 33, 4, 44},"222333444")]
        [InlineData(new uint[] { 10,11,12,13 }, "10111213")]
        [InlineData(new uint[] { 50, 9, 2, 1 }, "12509")]
        [InlineData(new uint[] {1,2 },"12")]
        [InlineData(new uint[] { 10, 2 }, "102")]
        [InlineData(new uint[] { 3,7,15,78 }, "153778")]
        [InlineData(new uint[] { 4294967295, 2 }, "24294967295")]
        [InlineData(new uint[] { 4294967295, 4294967295 }, "42949672954294967295")]
        [InlineData(new uint[] { 1, 4294967295 }, "14294967295")]
        public static void MIN_V_2___ShouldReturnString(uint[] args,string expected)
        {
            //arr

            //act
            string actual = Program.MIN_V_2(args);
            //ass
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData(new uint[] { 2,22,3,33,4,44 }, "444333222")]
        [InlineData(new uint[] { 50, 9, 2, 1 }, "95021")]
        [InlineData(new uint[] { 50, 1 }, "501")]
        [InlineData(new uint[] { 1, 2, 3 }, "321")]
        [InlineData(new uint[] { 100, 900 }, "900100")]
        [InlineData(new uint[] { 100, 2 }, "2100")]
        [InlineData(new uint[] { 4294967295, 4294967295 }, "42949672954294967295")]
        [InlineData(new uint[] { 5, 4294967295 }, "54294967295")]
        public static void MAX_V_2___ShouldReturnString(uint[] args, string expected)
        {
            string actual = Program.MAX_V_2(args);

            Assert.Equal(expected, actual);
        }



    }
}
