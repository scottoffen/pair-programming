using System;
using Shouldly;
using Xunit;

namespace SequenceGenerator.Tests
{
    public class SequenceTests
    {
        private Sequence _sequence;

        public SequenceTests()
        {
            _sequence = new Sequence();
        }

        [Theory]
        [InlineData("john", "J-Oo-Hhh-Nnnn")]
        [InlineData("Int3r35tinG", "I-Nn-Ttt-3333-Rrrrr-333333-5555555-Tttttttt-Iiiiiiiii-Nnnnnnnnnn-Ggggggggggg")]
        [InlineData("Sense8", "S-Ee-Nnn-Ssss-Eeeee-888888")]
        [InlineData("bn8b2p", "B-Nn-888-Bbbb-22222-Pppppp")]
        [InlineData("q&A", "Q-&&-Aaa")]
        public void ProducesCorrectSequence(string input, string expected)
        {
            var actual = _sequence.Generate(input);
            actual.ShouldBe(expected);
        }
    }
}
