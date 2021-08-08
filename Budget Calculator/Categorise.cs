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
    public partial class Categorise : Form
    {
        List<Transaction> transactions;
        /// <summary>
        /// Initialises form to the transaction list passed in.
        /// </summary>
        /// <param name="ts">The list of transactions to display</param>
        public Categorise(List<Transaction> ts)
        {
            InitializeComponent();
            transactions = ts;
            //Display transaction items into listview
            for (int i = 0; i < ts.Count; i++)
            {
                //Set number to transaction item
                ts[i].Number = i;
                //Add to listview
                ListViewItem item = new ListViewItem(ts[i].Number.ToString());
                item.SubItems.Add(ts[i].Date); item.SubItems.Add(ts[i].Payee);
                item.SubItems.Add(ts[i].Description); item.SubItems.Add(ts[i].Reference);
                item.SubItems.Add(ts[i].Particulars); item.SubItems.Add(ts[i].Amount.ToString("c"));
                listViewTransactions.Items.Add(item);
            }
        }

        /// <summary>
        /// Adds input as a category to combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            comboBoxCategories.Items.Add(textBoxCategory.Text);
            textBoxCategory.Clear();
        }

        /// <summary>
        /// Sets category to selected transactions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAllocate_Click(object sender, EventArgs e)
        {
            if (comboBoxCategories.SelectedItem == null) { MessageBox.Show("Please select a category."); }
            foreach (ListViewItem item in listViewTransactions.CheckedItems)
            {
                //Find item in list
                foreach(Transaction t in transactions)
                {
                    if (t.Number == int.Parse(item.Text))
                    {
                        //Set category to transaction
                        t.Category = comboBoxCategories.SelectedItem.ToString();
                        //Update listview to display category
                        item.SubItems.Add(t.Category);
                        item.SubItems[7].Text = t.Category;
                    }
                }
            }
        }

        /// <summary>
        /// Returns to homepage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelReturn_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 homepage = new Form1();
            homepage.ShowDialog(); this.Close();
        }
    }
}
