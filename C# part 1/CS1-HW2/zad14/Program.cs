using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad14
{
    class Program
    {
        static void Main(string[] args)
        {
            //A bank account has a holder name (first name, middle name and last name), available amount of
            //money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account.
            //Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
            string firstName="Ivan", middleName="Kostov", lastName="Ivanov";
            decimal balance=200101002.004124234m;
            string bankName="Rastafaraizen Bank";
            string IBAN="BG43564576587";
            string BIC = "STSABGSF";
            long creditCard1 = 1234123412341234, creditCard2 = 4321432143214312, creditCard3 = 1111222233334444;
        }
    }
}
