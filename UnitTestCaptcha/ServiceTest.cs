using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Captcha;
using NSubstitute;

namespace UnitTestCaptcha
{
    [TestFixture]
    class ServiceTest
    {
        Service service = new Service();

        [Test]
        public void GetCaptcha_ShouldBeOnePlus1()
        {
            var mock = Substitute.For<IRandommer>();
            mock.GetPattern().Returns(1);
            mock.GetOperand().Returns(1);
            mock.GetOperator().Returns(1);
            service.SetRandommer(mock);
            Assert.AreEqual("ONE + 1", service.GetCaptcha());
        }
    }
}
