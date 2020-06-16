using System;
using Xunit;

namespace avast_primnuber_assignment.Tests
{
    public class ReturnPrimNumberShould
    {
        [Fact]
        public void PrimNumberWhenN()
        {
            var primerNumber = new PrimNumbers();
            var result = primerNumber.DisplayPrimerNumber(50);

            Assert.True(true && result);
        }
    }
}
