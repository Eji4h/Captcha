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
            leftOperandDummy = 1,
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

        [Test]
        public void GetLeftOperand_ShouldThrowArgumentOutOfRangeException_WhenInputIsMinus1()
        {
            captcha = new _Captcha(patternDummy, -1, operatorValueDummy, rightOperandDummy);
            Assert.Throws<ArgumentOutOfRangeException>(() => captcha.GetLeftOperand());
        }

        [Test]
        public void GetLeftOperand_ShouldThrowArgumentOutOfRangeException_WhenInputIs10()
        {
            captcha = new _Captcha(patternDummy, 10, operatorValueDummy, rightOperandDummy);
            Assert.Throws<ArgumentOutOfRangeException>(() => captcha.GetLeftOperand());
        }

        [Test]
        public void GetRightOperand_ShouldBeNumberWord_WhenInputInRange()
        {
            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 0);
            Assert.AreEqual("ZERO", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 1);
            Assert.AreEqual("ONE", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 2);
            Assert.AreEqual("TWO", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 3);
            Assert.AreEqual("THREE", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 4);
            Assert.AreEqual("FOUR", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 5);
            Assert.AreEqual("FIVE", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 6);
            Assert.AreEqual("SIX", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 7);
            Assert.AreEqual("SEVEN", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 8);
            Assert.AreEqual("EIGHT", captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 9);
            Assert.AreEqual("NINE", captcha.GetRightOperand());
        }

        [Test]
        public void GetLeftOperand_ShouldThrowArgumentOutOfRangeException_WhenInputIsOutOfRange()
        {
            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, -1);
            Assert.Throws<ArgumentOutOfRangeException>(() => captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 10);
            Assert.Throws<ArgumentOutOfRangeException>(() => captcha.GetRightOperand());
        }
    }
}
