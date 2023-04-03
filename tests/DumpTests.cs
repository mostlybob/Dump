namespace Display.Tests
{
    using Display;
    using Shouldly;

    public class DumpTests
    {
        private Display.Output sut;

        [SetUp]
        public void Setup()
        {
            sut = new Display.Output();
        }

        [Test]
        public void It_should_handle_null()
        {
            var result = sut.Dump(null);

            result.ShouldBe("null");
        }

        [Test]
        public void It_should_return_a_string()
        {
            var testValue = Guid.NewGuid().ToString();

            var result = sut.Dump(testValue);

            result.ShouldBe(testValue);
        }

        [TestCase(458135791u)]
        [TestCase(-102482L)]
        [TestCase(8122572ul)]
        [TestCase(1.20f)]
        [TestCase(-123.2066f)]
        [TestCase(.25f)]
        [TestCase(0.555f)]
        [TestCase(1233.59d)]
        [TestCase(-33.654d)]
        [TestCase('a')]
        [TestCase('A')]
        [TestCase(true)]
        [TestCase(false)]
        public void It_should_return_a_string_for_numeric_type(object testValue)
        {
            var result = sut.Dump(testValue);

            result.ShouldBe(testValue.ToString());
        }

        [Test]
        public void It_should_handle_date()
        {
            DateTime testValue = DateTime.Now;

            var result = sut.Dump(testValue);

            result.ShouldBe(testValue.ToString());
        }

        [Test]
        public void It_should_print_a_collection_of_strings()
        {
            var testValue = new[] { "abc", "def" };

            var result = sut.Dump(testValue);

            // I'll want something a bit better looking in the future, but let's start here
            var expected = @"| abc |
| def |";

            result.ShouldBe(expected);
        }
    }
}