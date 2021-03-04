using System;
using Xunit;

namespace GitFlow.EM
{
    public class UnitTest1
    {
        [Fact]
        public void Soma_dois_mais_dois()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Fact]
        public void Soma_tres_mais_dois()
        {
            Assert.Equal(5, 3 + 2);
        }
    }
}
