using System;
using NUnit.Framework;
using _Captcha = Captcha.Captcha;

namespace UnitTestCaptcha
{
    [TestFixture]
    public class CaptchaTest
    {
        _Captcha captcha;

        [Test]
        public void GetLeftOperand_ShouldBe1_WhenInputIs1()
        {
            captcha = new _Captcha(1, 1, 1, 1);
            Assert.AreEqual("1", captcha.GetLeftOperand());
        }
    }
}
