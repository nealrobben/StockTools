using System;

namespace StockTools
{
    public static class Program
    {
        public static string Balance = "Balance";
        public static string CashFlow = "CashFlow";
        public static string Earnings = "Earnings";
        public static string Income = "Income";

        static void Main(string[] args)
        {
            if(args.Length == 2)
            {
                Console.WriteLine("Processing...");

                var option = args[0];
                var file = args[1];

                if (option.Equals(Balance, StringComparison.OrdinalIgnoreCase))
                    ProcessBalanceSheet(file);

                if (option.Equals(CashFlow, StringComparison.OrdinalIgnoreCase))
                    ProcessCashFlowStatement(file);

                if (option.Equals(Earnings, StringComparison.OrdinalIgnoreCase))
                    ProcessEarningsStatement(file);

                if (option.Equals(Income, StringComparison.OrdinalIgnoreCase))
                    ProcessIncomeStatement(file);
            }
            else
            {
                Console.WriteLine("Incorrect number of arguments given");
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static void ProcessBalanceSheet(string file)
        {
            
        }

        private static void ProcessCashFlowStatement(string file)
        {
            
        }

        private static void ProcessEarningsStatement(string file)
        {
            
        }

        private static void ProcessIncomeStatement(string file)
        {
            
        }
    }
}
