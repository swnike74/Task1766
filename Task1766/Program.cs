namespace Task1766
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommonAccount account1 = new CommonAccount();
            SalaryAccount account2 = new SalaryAccount();
            Calculator calculator = new Calculator();
            account1.SetBalance(500);
            account2.SetBalance(1000);

            calculator.CalculateInterest(account1);
            calculator.CalculateInterest(account2);
            Console.WriteLine($"Account1: тип {account1.Type}, Баланс {account1.Balance}, Процент {account1.Interest}");
            Console.WriteLine($"Account2: тип {account2.Type}, Баланс {account2.Balance}, Процент {account2.Interest}");
        }
    }
}
