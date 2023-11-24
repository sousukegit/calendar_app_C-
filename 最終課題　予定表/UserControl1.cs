using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 最終課題_予定表
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            
        }
        public void InsertLabel(string Day)
        {
            label1.Text = Day;
        }

        public void InsertListBox(int budget, int Spending, int Income)
        {
            listBox1.Items.Add(budget);
            listBox1.Items.Add(Spending);
            listBox1.Items.Add(Income);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
