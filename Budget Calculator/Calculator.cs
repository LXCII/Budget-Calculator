using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Calculator
{
    public partial class Calculator : Form
    {
        //List of transactions uploaded
        private List<Transaction> transactions;
        //The balance after income - expenses
        private decimal balance = 0;

        /// <summary>
        /// Initialises a calculator to the list of transactions passed in.
        /// </summary>
        /// <param name="ts">The transactions</param>
        public Calculator(List<Transaction> ts)
        {
            InitializeComponent();
            this.transactions = ts;
            //Initiate display
            processOverview();
            processSummary();
            //Set cursor focus 
            textBoxIncome.Focus();
        }

        /// <summary>
        /// Calculates the total income and expenses and the balance, and displays
        /// the values on the textboxes.
        /// </summary>
        private void processOverview()
        {
            decimal income = 0, expenses = 0;

            //Calculate total income and expenses
            foreach (Transaction t in transactions)
            {
                if (t.Amount >= 0)
                { income += t.Amount; }
                else
                { expenses += t.Amount; }
            }
            //Calculate balance
            balance = income + expenses;
            if (balance < 0) { textBoxBalance.BackColor = Color.Red; } else { textBoxBalance.BackColor = Color.Green;  }

            //Display values
            textBoxTotalIncome.Text = income.ToString("c");
            textBoxTotalExpenses.Text = expenses.ToString("c");
            textBoxBalance.Text = balance.ToString("c");
        } 

        /// <summary>
        /// Finds the categories where the user has spent the most and the least, and earned the most and the least from,
        /// and displays the results onto the textboxes.
        /// </summary>
        private void processSummary()
        {
            //Count total amount of a category in list
            Dictionary<string, decimal> categoriesIncome = new Dictionary<string, decimal>();
            Dictionary<string, decimal> categoriesExpenses = new Dictionary<string, decimal>();
            foreach (Transaction t in transactions)
            {
                //Income
                if (t.Amount >= 0)
                {
                    //Add to dictionary if category has not been added yet,
                    //Else, update amount in category
                    if (!categoriesIncome.ContainsKey(t.Category))
                    { categoriesIncome.Add(t.Category, t.Amount); }
                    else
                    { categoriesIncome[t.Category] = categoriesIncome[t.Category] + t.Amount; }
                }
                //Expenses
                else
                {
                    //Add to dictionary if category has not been added yet,
                    //Else, update amount in category
                    if (!categoriesExpenses.ContainsKey(t.Category))
                    { categoriesExpenses.Add(t.Category, t.Amount); }
                    else
                    { categoriesExpenses[t.Category] = categoriesExpenses[t.Category] + t.Amount; }
                }
            }

            //Display results
            textBoxMostEarned.Text = categoriesIncome.FirstOrDefault(x => x.Value == categoriesIncome.Values.Max()).Key;
            textBoxMostSpent.Text = categoriesExpenses.FirstOrDefault(x => x.Value == categoriesExpenses.Values.Max()).Key;
            textBoxLeastEarned.Text = categoriesIncome.FirstOrDefault(x => x.Value == categoriesIncome.Values.Min()).Key;
            textBoxLeastSpent.Text = categoriesExpenses.FirstOrDefault(x => x.Value == categoriesExpenses.Values.Min()).Key;
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Calculates the estimated balance after taking the projected income and expenses from the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Calculate estimated balance
            decimal estimated = balance + decimal.Parse(textBoxIncome.Text) - decimal.Parse(textBoxExpenses.Text);
            labelEstimated.Text = estimated.ToString("c");
            if (estimated > 0) { labelEstimated.BackColor = Color.Green; }
            else { labelEstimated.BackColor = Color.Red; }
        }
    }
}
