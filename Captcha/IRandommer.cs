﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public interface IRandommer
    {
        int GetPattern();
        int GetOperand();
        int GetOperator();
    }
}
