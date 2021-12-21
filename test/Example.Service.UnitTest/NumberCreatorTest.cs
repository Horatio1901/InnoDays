using Xunit;


namespace Example.Service.UnitTest
{
    using System.Collections.Generic;

    public class NumberCreatorTest
    {
        private readonly NumberCreator testee;

        public NumberCreatorTest()
        {
            this.testee = new NumberCreator();
        }

        [Fact]
        public void Create_NoNumbers_ShouldReturnNoNr()
        {
            var numbers = new int[] { };

            var result = this.testee.Create(numbers);

            Assert.Equal(
                new List<string> { },
                result);
        }

        [Fact]
        public void Create_divBy3Numbers_ShouldReturnFoo()
        {
            var numbers = new int[] { 3, 6, 9 };

            var result = this.testee.Create(numbers);

            Assert.Equal(
                new List<string> { "Foo", "Foo", "Foo" },
                result);
        }

        [Fact]
        public void Create_divBy5Numbers_ShouldReturnBar()
        {
            var numbers = new int[] { 5, 10 };

            var result = this.testee.Create(numbers);

            Assert.Equal(
                new List<string> { "Bar", "Bar" },
                result);
        }

        [Fact]
        public void Create_divBy7Numbers_ShouldReturnQix()
        {
            var numbers = new int[] { 7, 14 };

            var result = this.testee.Create(numbers);

            Assert.Equal(
                new List<string> { "Qix", "Qix" },
                result);
        }

        public static TheoryData<int[]> NumbersByThree()
            => new TheoryData<int[]> { new[] { 1, 2, 3, 4, 5 } };
    }
}