using System;
using NUnit.Framework;
using _Captcha = Captcha.Captcha;

namespace UnitTestCaptcha
{
    [TestFixture]
    public class CaptchaTest
    {
        _Captcha captcha;

        int patternDummy = 2,
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
        public void GetLeftOperand_ShouldThrowArgumentOutOfRangeException_WhenInputIsZero()
        {
            captcha = new _Captcha(patternDummy, 0, operatorValueDummy, rightOperandDummy);
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
            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => captcha.GetRightOperand());

            captcha = new _Captcha(patternDummy, leftOperandDummy, operatorValueDummy, 10);
            Assert.Throws<ArgumentOutOfRangeException>(() => captcha.GetRightOperand());
        }

        [Test]
        public void Operator_ShouldBePlus_WhenInputIs1()
        {
            captcha = new _Captcha(patternDummy, leftOperandDummy, 1, rightOperandDummy);
            Assert.AreEqual("+", captcha.GetOperator());
        }

        [Test]
        public void Operator_ShouldBeMultiply_WhenInputIs2()
        {
            captcha = new _Captcha(patternDummy, leftOperandDummy, 2, rightOperandDummy);
            Assert.AreEqual("*", captcha.GetOperator());
        }

        [Test]
        public void Operator_ShouldBeMinus_WhenInputIs3()
        {
            captcha = new _Captcha(patternDummy, leftOperandDummy, 3, rightOperandDummy);
            Assert.AreEqual("-", captcha.GetOperator());
        }

        [Test]
        public void Operator_ShouldThrowArgumentOutOfRangeException_WhenInputIsOutOfRange()
        {
            captcha = new _Captcha(patternDummy, leftOperandDummy, 0, rightOperandDummy);
            Assert.Throws<ArgumentOutOfRangeException>(() => captcha.GetOperator());

            captcha = new _Captcha(patternDummy, leftOperandDummy, 4, rightOperandDummy);
            Assert.Throws<ArgumentOutOfRangeException>(() => captcha.GetOperator());
        }

        [Test]
        public void GetRightOperand_ShouldBe1_WhenPatternIs1_And_InputIs1()
        {
            captcha = new _Captcha(1, leftOperandDummy, operatorValueDummy, 1);
            Assert.AreEqual("1", captcha.GetRightOperand());
        }

        [Test]
        public void GetRightOperand_ShouldBe2_WhenPatternIs1_And_InputIs2()
        {
            captcha = new _Captcha(1, leftOperandDummy, operatorValueDummy, 2);
            Assert.AreEqual("2", captcha.GetRightOperand());
        }

        [Test]
        public void GetLeftOperand_ShouldBeONE_WhenPatternIs1_And_InputIs1()
        {
            captcha = new _Captcha(1, 1, operatorValueDummy, rightOperandDummy);
            Assert.AreEqual("ONE", captcha.GetLeftOperand());
        }

        [Test]
        public void GetCaptcha_ShouldBeONEPlus1_WhenPatternIs1_LeftOperandIs1_OperatorIs1_RightOperandIs1()
        {
            captcha = new _Captcha(1, 1, 1, 1);
            Assert.AreEqual("ONE + 1", captcha.GetCaptcha());
        }

        [Test]
        public void GetCaptcha_ShouldBeTWOMultiply4_WhenPatternIs1_LeftOperandIs2_OperatorIs2_RightOperandIs4()
        {
            captcha = new _Captcha(1, 2, 2, 4);
            Assert.AreEqual("TWO * 4", captcha.GetCaptcha());
        }

        [Test]
        public void GetCaptcha_ShouldBe7MinusEIGHT_WhenPatternIs2_LeftOperandIs7_OperatorIs3_RightOperandIs8()
        {
            captcha = new _Captcha(2, 7, 3, 8);
            Assert.AreEqual("7 - EIGHT", captcha.GetCaptcha());
        }
    }
}
