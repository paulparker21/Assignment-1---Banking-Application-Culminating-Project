using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1___Banking_Application_Culminating_Project
{
    class returnedVal
    {
        internal string EnterCalulate()

        {

            Console.WriteLine("Calulate:");

            string Calculate = Console.ReadLine();

            return Calculate;

        }

        internal float AmountToDeposit()

        {

            Console.WriteLine("Type in the amount ");

            float sum = float.Parse(Console.ReadLine());

            return sum;

        }

        internal bankAccount GetAccountByName(string Calculate, List<bankAccount> _conturi)

        {

            bankAccount ba = _conturi.Find(c => c.Calculate == Calculate);

            if (ba != null)

            {

                return ba;

            }

            else

            {

                return null;

            }

        }

    }

   
