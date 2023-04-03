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
            result.ShouldNotBeNull();

        }
    }
}