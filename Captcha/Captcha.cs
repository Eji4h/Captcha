using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public class Captcha
    {
        int pattern;
        int leftOperand;
        int rightOperand;
        int operatorValue;

        List<string> numberWordList = new List<string>()
        {
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE"
        };

        public Captcha(int pattern, int leftOperand, int operatorValue, int rightOperand)
        {
            this.pattern = pattern;
            this.leftOperand = leftOperand;
            this.operatorValue = operatorValue;
            this.rightOperand = rightOperand;
        }

        public string GetLeftOperand()
        {
            if (leftOperand < 0 || leftOperand > 9)
                throw new ArgumentOutOfRangeException();
            if (pattern == 1)
                return "ONE";
            return leftOperand.ToString();
        }

        public string GetRightOperand()
        {
            if (rightOperand < 0 || rightOperand > 9)
                throw new ArgumentOutOfRangeException();
            if (pattern == 1)
                return rightOperand.ToString();
            return numberWordList[rightOperand];
        }

        public string GetOperator()
        {
            switch(operatorValue)
            {
                case 1: return "+";
                case 2: return "*";
                case 3: return "-";
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
