using System;
using Xunit;

namespace _20210204Mastermind
{
    public class BasicTests
    {
        readonly private MasterMind mm = new MasterMind();

        [Fact]
        public void Instantiation()
        {
            (int black, int white) = mm.Eval("");
        }
    }
}
