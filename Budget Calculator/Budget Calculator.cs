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

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            //Declare variables
            StreamReader reader;
            string[] transactions;
            const string FILTER = "CSV Files|*.csv|All Files|*.*";
            string line = "", date = "", payee = "", description = "", 
                reference = "", particulars = "";
            decimal amount = 0, balance = 0;

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
                            payee = transactions[2];
                            description = transactions[3];
                            reference = transactions[4];
                            particulars = transactions[5]; //Only gets first line of particulars

                            //Calculate balance
                            balance += amount;
                            //Display balance
                            textBoxBalance.Text = balance.ToString("c");
                            //Change colour of textbox according to balance
                            if (balance < 0) { textBoxBalance.BackColor = Color.Red; } else { textBoxBalance.BackColor = Color.Green;  }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: " + line); //Display error message
                    }
                }
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
