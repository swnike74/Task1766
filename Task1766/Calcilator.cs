using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1766
{
    public class Calculator
    {
        public void CalculateInterest(CommonAccount CAccount)
        {
            CAccount.CalculateInterest();
        }
        public void CalculateInterest(SalaryAccount SAccount)
        {
            SAccount.CalculateInterest();
        }
    }
}
