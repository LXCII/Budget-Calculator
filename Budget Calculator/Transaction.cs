using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Calculator
{
    public class Transaction
    {
        //Variables of a transaction
        private string date, payee, description, reference, particulars, category;
        private decimal amount;

        /// <summary>
        /// Initialises a transaction to the variables passed in.
        /// </summary>
        /// <param name="dt">Date of transaction</param>
        /// <param name="py">Payee of transaction</param>
        /// <param name="dc">Description of transaction</param>
        /// <param name="rf">Reference of transaction</param>
        /// <param name="pt">Particulars of transaction</param>
        /// <param name="am">Amount of transaction</param>
        public Transaction(string dt, string py, string dc, string rf, string pt, decimal am)
        {
            date = dt; payee = py; description = dc; reference = rf;
            particulars = pt; amount = am;
        }

        #region Properties
        public string Date
        {
            get { return date; }
        }

        public string Payee
        {
            get { return payee; }
        }

        public string Description
        {
            get { return description; }
        }

        public string Reference
        {
            get { return reference; }
        }

        public string Particulars
        {
            get { return particulars; }
        }

        public decimal Amount
        {
            get { return amount; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        #endregion
    }
}
