using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public class Captcha
    {
        enum Pattern
        {
            WordOperatorNumber = 1,
            NumberOperatorWord = 2
        }

        Pattern pattern;
        int leftOperand;
        int rightOperand;
        int operatorValue;

        List<string> numberWordList = new List<string>()
        {
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE"
        };

        public Captcha(int pattern, int leftOperand, int operatorValue, int rightOperand)
        {
            this.pattern = (Pattern)pattern;
            this.leftOperand = leftOperand;
            this.operatorValue = operatorValue;
            this.rightOperand = rightOperand;
        }

        public string GetLeftOperand()
        {
            ValidateInRangeZeroToNine(leftOperand);
            if (pattern == Pattern.WordOperatorNumber)
                return GetOperandWord(leftOperand);
            return leftOperand.ToString();
        }

        public string GetRightOperand()
        {
            ValidateInRangeZeroToNine(leftOperand);
            if (pattern == Pattern.NumberOperatorWord)
                return GetOperandWord(rightOperand);
            return rightOperand.ToString();
        }

        public string GetOperator()
        {
            switch (operatorValue)
            {
                case 1: return "+";
                case 2: return "*";
                case 3: return "-";
                default: throw new ArgumentOutOfRangeException();
            }
        }

        void ValidateInRangeZeroToNine(int operand)
        {
            if (operand < 0 || operand > 9)
                throw new ArgumentOutOfRangeException();
        }

        string GetOperandWord(int operand)
        {
            return numberWordList[operand];
        }

        public string GetCaptcha()
        {
            return string.Format("{0} {1} {2}", GetLeftOperand(), GetOperator(), GetRightOperand());
        }
    }
}
