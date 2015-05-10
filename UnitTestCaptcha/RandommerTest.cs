using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Captcha;

namespace UnitTestCaptcha
{
    [TestFixture]
    class RandommerTest
    {
        Randommer randommer = new Randommer();

        [Test]
        public void GetPatternIsRandomInRange()
        {
            Assert.That(randommer.GetPattern(), Is.InRange(1, 2));
        }

        [Test]
        public void GetOperandnIsRandomInRange()
        {
            Assert.That(randommer.GetOperand(), Is.InRange(0, 9));
        }
    }
}
