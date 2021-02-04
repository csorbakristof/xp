using System;
using MasterMindCommon;
using Xunit;

namespace _20210204Mastermind
{
    public class BasicTests
    {
        readonly private MasterMind mm = new MasterMind();

        [Fact]
        public void Instantiation()
        {
            var result = mm.Eval("", "");
            Assert.Equal((0, 0), result);
        }

        [Theory]
        [InlineData("AAAA", "AAAA", 4, 0)]
        [InlineData("AAAB", "AAAA", 3, 0)]
        [InlineData("ABBB", "CCCA", 0, 1)]
        [InlineData("ABCD", "BEEA", 0, 2)]
        [InlineData("ABCD", "ABDC", 2, 2)]
        public void EvalTests(string correct, string guess, int black, int white)
        {
            var result = mm.Eval(correct, guess);
            Assert.Equal((black, white), result);
        }

        [Fact]
        public void TestGame()
        {
            var correct = "ABCD";
            Assert.Equal((0, 2), mm.Eval("BEAF", correct));
            Assert.Equal((1, 2), mm.Eval("BEAD", correct));
            Assert.Equal((2, 1), mm.Eval("BECD", correct));
            Assert.Equal((2, 2), mm.Eval("BACD", correct));
            Assert.Equal((4, 0), mm.Eval("ABCD", correct));
        }
    }
}
