using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public class Randommer
    {
        Random random = new Random();

        public int GetPattern()
        {
            return random.Next(1, 3);
        }
    }
}
