using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public class Captcha
    {
        int leftOperand;
        int rightOperand;

        List<string> numberWordList = new List<string>()
        {
            "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE"
        };

        public Captcha(int pattern, int leftOperand, int operatorValue, int rightOperand)
        {
            this.leftOperand = leftOperand;
            this.rightOperand = rightOperand;
        }

        public string GetLeftOperand()
        {
            if (leftOperand < 0 || leftOperand > 9)
                throw new ArgumentOutOfRangeException();
            return leftOperand.ToString();
        }

        public string GetRightOperand()
        {
            return numberWordList[rightOperand - 1];
        }
    }
}
