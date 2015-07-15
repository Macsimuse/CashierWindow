using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using Silpo;

namespace WindowCassier
{
    public partial class Form1 : Form
   {
        AvailebleElements availebtElements = new AvailebleElements();
        LoginPassword login = new LoginPassword();
         DataElements dtElements = new DataElements();
         Shoping shoping = new Shoping();

        // This global varible response for checking if user already in System. Button Print reset to 0.
        int OnlyOneTime = 0;

        string logOff = "Log in first in System";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        // Button Buy calculate whole Bill, but does not Reset a Calculation-Process
        // To Close a bill Cassier should Print it, using button Print.
        private void Buy_Click(object sender, EventArgs e)
        {
            Clean();
            
            if (login.Acess)
            {
                try
                {
                    foreach (string selection in shoping)
                    {
                        MONITOR.Items.Add(selection);

                    }
                    MONITOR.Items.Add(String.Format("Total count = {0}", shoping.Count));
                    label2.Text = String.Format("Price:  {0:C}\nDiscount:  {1:C}\nTotal Price: {2:C}", shoping.CalculateSum(), shoping.CalculateDiscount(Bonus.Text), shoping.CalculateSum() - shoping.CalculateDiscount(Bonus.Text));
                }
                catch (NullReferenceException ex)
                {
                    label2.Text = ex.Message;
                }
            }
            else
                label2.Text = logOff; 
        }

        #region Login button
        private void Entry_Click(object sender, EventArgs e)
        {
           
            bool ShowAcess = login.InGuard(Login.Text, Password.Text);
            label6.Text = String.Empty;

            if (OnlyOneTime == 0)
            {
                if (ShowAcess)
                {
                    label6.Text = "In System";
                    OnlyOneTime++;
                }
                else
                    label6.Text = "Wrong!Try againe";
            }
            else
                label6.Text = "Already in System!";
        }
        #endregion

        // Two action: 1.Add new items to bill; 2. Immediately shows current type ID on display;
        private void Add_Click(object sender, EventArgs e)
        {
            Clean();
            if (login.Acess)
            {
                try
                {
                    shoping.AddToBill(Choise.Text);
                    MONITOR.Items.Add(Choise.Text);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(label2.Text = ex.Message);
                }
            }
            else label2.Text = logOff;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            label2.Text = String.Empty;
            shoping.CleanBill();
            if (login.Acess)
            {
                label2.Text = String.Format("Take Your Bill\nHave a nice Day!");
            }
            else label2.Text = logOff;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Clean();
            login.Acess = false;
            Choise.Text = String.Empty;
            Bonus.Text = String.Empty;                
            OnlyOneTime = 0;
            label6.Text = "Acces in System";
        }

        private Form Clean()
        {
            Login.Text = String.Empty;
            Password.Text = String.Empty;
            label2.Text = String.Empty;
            MONITOR.Items.Clear();
            return this;
        }        

    }
}
