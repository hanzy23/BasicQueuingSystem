using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace BasicQueuingSystem

{
    
    public partial class Form2 : Form
    {
        public static string nowServing;

        Form3 f3;
        public Form2()
        {
            
            InitializeComponent();
            f3 = new Form3();
          
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList){
                listCashierQueue.Items.Add(obj.ToString());

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            f3.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string toServe = CashierClass.CashierQueue.Peek();
            f3.lblQueue.Text = toServe;
            CashierClass.CashierQueue.Dequeue();
             
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
