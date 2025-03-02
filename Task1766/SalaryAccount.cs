using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task1766
{
    public class SalaryAccount : ICalculateInterest
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
        public SalaryAccount()
        {
            Type = "Зарплатный";
        }

        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
        public void SetBalance(int balance)
        {
            Balance = balance;
        }
    }
}
