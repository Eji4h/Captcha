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

        [Test]
        public void GetLeftOperand_ShouldBe2_WhenInputIs2()
        {
            captcha = new _Captcha(1, 2, 1, 1);
            Assert.AreEqual("2", captcha.GetLeftOperand());
        }
    }
}
