using System;
using NUnit.Framework;
using _Captcha = Captcha.Captcha;

namespace UnitTestCaptcha
{
    [TestFixture]
    public class CaptchaTest
    {
        _Captcha captcha;

        int patternDummy = 1,
            operatorValueDummy = 1,
            rightOperandDummy = 1;

        [Test]
        public void GetLeftOperand_ShouldBe1_WhenInputIs1()
        {
            captcha = new _Captcha(patternDummy, 1, operatorValueDummy, rightOperandDummy);
            Assert.AreEqual("1", captcha.GetLeftOperand());
        }

        [Test]
        public void GetLeftOperand_ShouldBe2_WhenInputIs2()
        {
            captcha = new _Captcha(patternDummy, 2, operatorValueDummy, rightOperandDummy);
            Assert.AreEqual("2", captcha.GetLeftOperand());
        }

        [Test]
        public void GetLeftOperand_ShouldBe9_WhenInputIs9()
        {
            captcha = new _Captcha(patternDummy, 9, operatorValueDummy, rightOperandDummy);
            Assert.AreEqual("9", captcha.GetLeftOperand());
        }
    }
}
