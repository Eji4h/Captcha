using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public class Captcha
    {
        private int leftOperand;

        public Captcha(int pattern, int leftOperand, int operatorValue, int rightOperand)
        {
            this.leftOperand = leftOperand;
        }

        public string GetLeftOperand()
        {
            if (leftOperand < 0)
                throw new ArgumentOutOfRangeException();
            return leftOperand.ToString();
        }
    }
}
