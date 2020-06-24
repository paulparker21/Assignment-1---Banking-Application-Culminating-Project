using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1___Banking_Application_Culminating_Project
{
    class Calculate
    {
        static Random generator = new Random();

        string accountNumber = generator.Next(100, 999).ToString();

        public string Calculate()

        {

            return accountNumber;

        }

    }
}

