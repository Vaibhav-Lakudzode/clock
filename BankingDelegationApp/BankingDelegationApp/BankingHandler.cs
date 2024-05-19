using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDelegationApp
{
    public delegate void BankingHandler(object? obj, EventArgs e);

    public delegate int ArithmaticOperaiton(int num1, int num2);
        
   
}
