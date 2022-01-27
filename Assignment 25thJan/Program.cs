using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2Part_1
{
    class Accounts
    {
        long AccNo;
        string CustName;
        string AccType;
        string TranType;
        float Amount;
        float Balance=20000;

        public  Accounts(long Accnum, string name, string AccountType)
        {
            AccNo = Accnum;
            CustName = name;
            AccType = AccountType;
        }

        public void Credit(int amt)
        {
            Amount = amt;
            Balance = Balance + Amount;
            Console.WriteLine($"Balance in the Account after deposit of{Amount}rs is: {Balance}rs\n");
        }

        public void Debit(int amt)
        {
            Amount = amt;
            Balance = Balance - Amount;
            Console.WriteLine($"Balance in the Account after withdrawal of:{Amount}rs is: {Balance}rs");
        }

        public void showData()
        {
            Console.WriteLine($"The Account number: {AccNo} of {CustName} has {Balance}rs left");
        }
        class Program
        {
            static void Main(string[] args)
            {
                string tt;
                long ano;
                string n;
                int amt;
                string atyp;

                Console.WriteLine("--------  Welcome to SKS Bank  -----------");
                Console.Write("You want to withdraw amount or deposit cash, select ur choice(w/d): ");
                tt = Console.ReadLine();
                Console.Write("Enter account type(savings/current): ");
                atyp = Console.ReadLine();
                Console.Write("Enter Account number: ");
                ano = Convert.ToInt64(Console.ReadLine());
                Console.Write("Enter account holder name: ");
                n = Console.ReadLine();
                Console.Write("Enter Amount: ");
                amt = Convert.ToInt32(Console.ReadLine());

                Accounts a = new Accounts(ano,n,atyp);
                Console.WriteLine("dsdsd"+tt);

                if (tt.Equals("w")|| tt.Equals("W"))
                {
                    a.Debit(amt);
                }
                else if(tt.Equals("d")|| tt.Equals("D"))
                {
                    a.Credit(amt);
                }
                else
                {
                    a.showData();
                }
                Console.WriteLine("Thanks for visting, Please do visit again!!! ");
                Console.ReadLine();
            }
        }
    }
}
