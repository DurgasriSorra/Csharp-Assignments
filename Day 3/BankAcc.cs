using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    
        class BankAcc
        {
            double balance;

            public BankAcc()
            {
                balance = 500;
            }
            public BankAcc(double balance)
            {


                this.balance = balance;
            }



            public double getBalance()
            {
                return balance;
            }


        }
        class BankTest
        {
            public static void Main(string[] args)
            {
                BankAcc b1 = new BankAcc();
                Console.WriteLine("default balance=" + b1.getBalance());
                BankAcc b2 = new BankAcc(1000);
                Console.WriteLine(" balance=" + b2.getBalance());

            }
        }
    }
