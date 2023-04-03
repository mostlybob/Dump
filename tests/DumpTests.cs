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

        [Test]
        public void It_should_return_an_integer_string()
        {
            int testValue=458135791;

            var result = sut.Dump(testValue);

            result.ShouldBe(testValue.ToString());
        }
    }
}