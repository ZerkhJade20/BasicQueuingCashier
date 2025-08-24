using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CashierWindowQueue : Form
    {
        ViewServing view = new ViewServing();
        public CashierWindowQueue()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 1 sec.
timer.Tick += new EventHandler(timer1_Tick); //timer1_tick represents the name of Tick Event
            timer.Start();
            view.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                string next = CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue (CashierClass.CashierQueue);
                view.NowServing(next);
            }
            else
            {
                MessageBox.Show("No Customer.");
            }
                
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
