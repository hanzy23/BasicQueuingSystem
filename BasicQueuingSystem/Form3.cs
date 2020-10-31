using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicQueuingSystem
{
    public partial class Form3 : Form
    {
        CashierClass cashier;
        public Form3()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Contains(CashierClass.getNumberInQueue);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

     
    }
}
