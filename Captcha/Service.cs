using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public class Service
    {
        IRandommer randommer;

        public void SetRandommer(IRandommer randommer)
        {
            this.randommer = randommer;
        }

        public string GetCaptcha()
        {
            return new Captcha(randommer.GetPattern(), randommer.GetOperand(), 
                randommer.GetOperator(), randommer.GetOperand()).GetCaptcha();
        }
    }
}
