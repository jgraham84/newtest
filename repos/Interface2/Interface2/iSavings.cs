using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface iSavings : iCredit
    {

        int mySav(int a = 5000, int b = 1 - 5000);

        int myCred(int c = 20);

        int myMinus(int d = 19);











    }
}
