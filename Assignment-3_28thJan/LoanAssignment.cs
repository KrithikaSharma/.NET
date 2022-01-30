using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_28thJan
{
    // problem stmt:
    /*
    2. Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount, Account_Balance as its members.
    Create a method calculate_EMI() for the LoanAmount , with the rate of interest as 13% for a total of 3 years
    and store it in the EMI_Amount. The rest of the information to be passed through constructors.
    Write another function CheckBalance() which checks if the Account_Balance is less than the EMI_AMount.
    If yes then throw a custom exception. Display " Not Sufficient Balance to repay Loan" in the finally.
    Give explanatory comments.
    */
    class LoanException : ApplicationException
    {
        public LoanException(string msg) : base(msg)
        {

        }
    }
    class LoanProcess
    {
        long Loan_No;
        string CustomerName;
        float loanAmount;
        float EMIAmount;
        float AccountBalance;
        float numerator;
        float denominator;
        float ROI;
        int tenure;
        

        public LoanProcess(long lno, string cname, float AccBal, float roi, int t)
        {
            Loan_No = lno;
            CustomerName = cname;
            AccountBalance = AccBal;
            ROI = roi;
            tenure = t;
            EMIAmount = numerator / denominator;
            
        }
        public void CalculateEMI(float LAmt)
        {
            // EMI = principal amount + interest paid on the personal loan.
            // EMI Amount = [P x R x (1+R)^N]/[((1+R)^N)-1] where P, R, and N are the variables.
            // Equated monthly installments as in the name amount must be paid monthly
            // to convert into monthly = R/[100 *12] 12 since 12 months in a year and 100 for percentage
            // monthly=13/(100*12) => 0.01084
            // tenure is of 3 years... we need to find montly tenure so, 3*12=36months
            
            float monthlyRate = ROI / (100 * 12);
            float monthlyTenure = tenure * 12;


            numerator = (float)(LAmt * monthlyRate * Math.Pow(1+monthlyRate, monthlyTenure));
            denominator = (float)((Math.Pow(1 + monthlyRate, monthlyTenure) - 1));
            EMIAmount = numerator / denominator;
        }

        public void CheckBalance(float accbal)
        {
            if (accbal < EMIAmount)
            {
                throw (new LoanException("Not sufficient balance to repay loan"));
            }
            else
            {
                Console.WriteLine($"You need to pay monthly: {EMIAmount}rs");
            }
        }
    }
    class LoanAssignment
    {
        static void Main()
        {
            
            LoanProcess lp = new LoanProcess(00012678263, "Krithika", 1000000, 12,5); //can take userinput too

            try
            {
                lp.CalculateEMI(1000000);
                lp.CheckBalance(70000);
            }
            catch (LoanException le)
            {
                Console.WriteLine("LoanException message: " + le.Message);
            }
            Console.Read();
        }
    }
}
//output
/*
You need to pay monthly: 22244.45rs
*/
