using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDD
{
    public class XUnityExampleTests: IDisposable
    {
        public XUnityExampleTests()
        {

        }

        [Fact]
        public void TestName()
        {
            //arrange

            //act

            //assert
            Assert.True(true);
        }

        public void Dispose()
        {

        }
    }
}
