﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater.Calc
{
    class Substr : ICalc
    {
        double ICalc.DoMath(double tmp1, double tmp2)
        {
            return tmp1 - tmp2;
        }
    }
}
