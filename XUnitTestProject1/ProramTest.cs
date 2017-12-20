using System;
using Xunit;
using TestApp;

namespace XUnitTestProject1
{
    public class ProramTest
    {
        [Fact]
        public void TestTheFoo()
        {
            Assert.Equal("foo", Program.Foo());
        }
    }
}
