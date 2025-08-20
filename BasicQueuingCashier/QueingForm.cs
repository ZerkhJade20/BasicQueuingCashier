using System;
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
     
    public partial class QueingForm : Form
    {
        
        private CashierClass cashier;
        CashierWindowQueue queueForm = new CashierWindowQueue();

        public QueingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            queueForm.Show();
            
        }

      

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
        private void QueingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
