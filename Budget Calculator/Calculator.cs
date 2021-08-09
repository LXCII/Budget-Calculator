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
        private List<Transaction> transactions;
        private decimal balance = 0;

        public Calculator(List<Transaction> ts)
        {
            InitializeComponent();
            this.transactions = ts;
            processOverview();
            processSummary();
            textBoxIncome.Focus();
        }

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

        private void processSummary()
        {
            //Count occurrences of a category in list
            Dictionary<string, decimal> categoriesIncome = new Dictionary<string, decimal>();
            Dictionary<string, decimal> categoriesExpenses = new Dictionary<string, decimal>();
            foreach (Transaction t in transactions)
            {
                if (t.Amount >= 0)
                {
                    if (!categoriesIncome.ContainsKey(t.Category))
                    { categoriesIncome.Add(t.Category, t.Amount); }
                    else
                    { categoriesIncome[t.Category] = categoriesIncome[t.Category] + t.Amount; }
                }
                else
                {
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

        private void labelExit_Click(object sender, EventArgs e)
        {
            Close();
        }

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
