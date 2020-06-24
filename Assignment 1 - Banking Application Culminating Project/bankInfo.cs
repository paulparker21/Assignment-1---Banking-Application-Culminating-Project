using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1___Banking_Application_Culminating_Project
{
    class bankInfo
    {
        returnedVal rv = new returnedVal();

        List<bankAccount> _accounts;

        public bankInfo()

        {

            _accounts = new List<bankAccount>();

        }

        public List<bankAccount> Account

        {

            get { return _accounts; }

        }

        public void CreateAccount(string name)

        {

            bankAccount account = new bankAccount();

            Calculate calculate = new Calculate();

            try

            {

                if (!String.IsNullOrEmpty(name))

                {

                    account.Name = name;

                   

                    _accounts.Add(account);

                   

                }

                else

                {

                    Console.WriteLine("Account name is null or empty.");

                }

            }

            catch (NullReferenceException ne)

            {

                Console.WriteLine(ne.StackTrace);

            }

        }

        public float Deposit()

        {

            string iban = rv.EnterCalulate();

            bankAccount account = rv.GetAccountByName(Calculate, _accounts);

            while (account == null)

            {

                Console.WriteLine("Account doesn't exist");

                iban = rv.EnterCalulate();

                account = rv.GetAccountByName(iban, _accounts);

            }

            float sum = rv.AmountToDeposit();

            while (sum <= 0)

            {

                Console.WriteLine("Amount cannot be less or equal than 0.");

                sum = 0;

                sum = rv.AmountToDeposit();

            }

            account.Sum += sum;

            Console.WriteLine("Added {0} to account {1}", sum, iban);

            return account.Sum;

        }

        public float Withdraw()

        {

            bankInfo details = new bankInfo();

            bankInfo.Comision c = Comission.Comision;

            string iban = rv.EnterCalulate();

            bankAccount account = rv.GetAccountByName(Calculate, _accounts);

            while (account == null)

            {

                Console.WriteLine("Account doesn't exist");

                iban = rv.EnterCalculate();

                account = rv.GetAccountByName(Calculate, _accounts);

            }

            float sum = rv.AmountToDeposit();

            while (sum <= 0)

            {

                Console.WriteLine("Amount cannot be less or equal than 0.");

                sum = 0;

                sum = rv.AmountToDeposit();

            }

            account.Sum -= sum;

            Console.Write("Withdrawn {0} from account {1}.", sum, Calculate);

            Console.WriteLine("Comision {0}", Math.Round(c(account.Sum), 2));

            account.Sum -= c(account.Sum);

            Console.WriteLine("Remaining: {0}", Math.Round(account.Sum, 2));

            return account.Sum;

        }

        public float Balance()

        {

            string iban = rv.EnterCalulate();

            bankAccount account = rv.GetAccountByName(Calculate, _accounts);

            Console.WriteLine(": {0} has {1} left", Calculate, account.Sum);

            return account.Sum;

        }

    }
}

