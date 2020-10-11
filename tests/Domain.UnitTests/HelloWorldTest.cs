using FluentAssertions;
using Xunit;

namespace Domain.UnitTests
{
    public class HelloWorldTest
    {
        private static string HelloWorldString = "HELLO WORLD";

        private bool ContainsHelloWorld(string text)
        {
            return text.ToUpper().Contains(HelloWorldString);
        }

        [Theory]
        [InlineData("I would say hello world!")]
        [InlineData("Hello WoRlD")]
        public void If_TestStringContainsHelloWorld_Then_ShouldReturnTrue(string testCase)
        {
            var result = ContainsHelloWorld(testCase);
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("")]
        [InlineData("Hello my World")]
        public void If_TestStringContainsNotHelloWorld_Then_ShouldReturnFalse(string testCase)
        {
            var result = ContainsHelloWorld(testCase);
            result.Should().BeFalse();
        }
    }
}