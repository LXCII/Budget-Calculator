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
        public Categorise(List<Transaction> ts)
        {
            InitializeComponent();

            //Display transaction items into listview
            for (int i = 0; i < ts.Count; i++)
            {
                ListViewItem item = new ListViewItem(ts[i].Date);
                item.SubItems.Add(ts[i].Payee); item.SubItems.Add(ts[i].Description);
                item.SubItems.Add(ts[i].Reference); item.SubItems.Add(ts[i].Particulars);
                item.SubItems.Add(ts[i].Amount.ToString("c"));
                listViewTransactions.Items.Add(item);
            }
        }
    }
}
