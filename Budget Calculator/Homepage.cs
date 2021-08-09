using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prompts the user to upload a .csv file and reads 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            //Declare variables
            StreamReader reader;
            List<string> dates = new List<string>(); List<string> payees = new List<string>();
            List<string> descriptions = new List<string>(); List<string> references = new List<string>();
            List<string> particulars = new List<string>(); List<decimal> amountVals = new List<decimal>();
            List<Transaction> ts = new List<Transaction>();
            string[] transactions;
            const string FILTER = "CSV Files|*.csv|All Files|*.*";
            string date, payee, desc, refr, parts, line = "";
            decimal balance, amount = 0;

            //Set filter for dialog control
            openFileDialog1.Filter = FILTER;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open file
                reader = File.OpenText(openFileDialog1.FileName);

                //Read values
                while (!reader.EndOfStream)
                {
                    try
                    {
                        //Read a line from the file
                        line = reader.ReadLine();
                        //Split values from the line
                        transactions = line.Split(',');

                        if (transactions[0] != "Date")
                        {
                            //Extract values into separate variables
                            date = transactions[0];
                            amount = decimal.Parse(transactions[1]);
                            payee = transactions[2].Substring(1, transactions[2].Length - 2);
                            desc = transactions[3].Substring(1, transactions[3].Length - 2);
                            if (transactions[4] != "") { refr = transactions[4].Substring(1, transactions[4].Length - 2); }
                            else { refr = transactions[4]; }
                            if (transactions[5] != "") { parts = transactions[5].Substring(1, transactions[5].Length - 2); }
                            else { parts = transactions[5]; }

                            //Create transaction and add to list
                            Transaction t = new Transaction(date, payee, desc, refr, parts, amount);
                            ts.Add(t);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: " + line); //Display error message
                    }
                }

                //Open Categorise window
                Hide();
                Categorise c = new Categorise(ts);
                c.ShowDialog(); this.Close();
            }
            
        }

        /// <summary>
        /// Closes the applicaiton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
