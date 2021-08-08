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
        public Categorise(List<string> dt, List<string> py, List<string> dc, List<string> r, List<string> pr, List<decimal> a)
        {
            InitializeComponent();

            //Display transaction items into listview
            for (int i = 0; i < dt.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt[i].ToString());
                item.SubItems.Add(py[i]); item.SubItems.Add(dc[i]);
                item.SubItems.Add(r[i]); item.SubItems.Add(pr[i]);
                item.SubItems.Add(a[i].ToString("c"));
                listViewTransactions.Items.Add(item);
            }
        }
    }
}
