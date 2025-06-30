using System.Net.WebSockets;
using Microsoft.VisualBasic;

namespace Program
{
    public class Program
    {

        public static void Main(string[] args)
        {

            string bankRecords = """
            DEPOSIT,   10000, Initial balance
            DEPOSIT,     500, regular deposit
            WITHDRAWAL, 1000, rent
            DEPOSIT,    2000, freelance payment
            WITHDRAWAL,  300, groceries
            DEPOSIT,     700, gift from friend
            WITHDRAWAL,  150, utility bill
            DEPOSIT,    1200, tax refund
            WITHDRAWAL,  500, car maintenance
            DEPOSIT,     400, cashback reward
            WITHDRAWAL,  250, dining out
            DEPOSIT,    3000, bonus payment
            WITHDRAWAL,  800, loan repayment
            DEPOSIT,     600, stock dividends
            WITHDRAWAL,  100, subscription fee
            DEPOSIT,    1500, side hustle income
            WITHDRAWAL,  200, fuel expenses
            DEPOSIT,     900, refund from store
            WITHDRAWAL,  350, shopping
            DEPOSIT,    2500, project milestone payment
            WITHDRAWAL,  400, entertainment
            """;

            double currentBalance = 0.0;
            var reader = new StringReader(bankRecords);

            //? allows null value
            string? line;
            //while line isn't null or while reader isn't null
            while ((line = reader.ReadLine()) is not null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                //string[] = array of strings
                //line.split = split line at stated marker or value
                string[] parts = line.Split(',');

                //nullable string of trimmed string array parts
                string? transactionType = parts[0]?.Trim();
                //double.tryparse checks if string can be parsable to double instead of int
                //out double converts string to double after parse check and sets it as the value of amount
                if (double.TryParse(parts[1].Trim(), out double amount))
                {
                    //update balance based on transaction type
                    //if index [1] has a parsable value check index [0] for transaction type
                    if (transactionType?.ToUpper() is "DEPOSIT")
                        currentBalance += amount;

                    else if (transactionType?.ToUpper() is "WITHDRAWAL")
                        currentBalance -= amount;

                    Console.WriteLine($"{line.Trim()} => Parsed Amount: {amount}, New Balance: {currentBalance}");
                }
            }
        
        }
    }
}