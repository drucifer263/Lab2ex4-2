using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal_4_2_Enhanced
{
    /*
     Drew Watson
     Lab assignment 2 
     4.2
     Friedman
     Component Spring 2018
     */

    public partial class frmInvoiceTotal : Form
    {
        //Class variables
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        //Sets largest and smallest to some arbitrary value to be compared to later
        decimal smallestInvoice = Decimal.MaxValue, largerstInvoice = Decimal.MinValue;

        public frmInvoiceTotal()
        {
            InitializeComponent();
        }


        //Calculates invoice total when clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declared and initilized variables
            decimal subtotal = 0, discountPercent = .25m, discountAmount = 0, invoiceTotal = 0/*,smallestInvoice = 0, largerstInvoice = 0*/;

            //Try that checks the validation of the NumberGrade txtbox
            try
            {

                //Converts to a decimal and places the entry from  enter subtotal txt box to subtotal variable
                subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);

                //Throws an exception if subtotal is less than zero
                if (subtotal < 0)
                {
                    throw new Exception("Subtotal can not be less than zero");
                }

                //Converts and places subtotal into subtotaltxtbox
                txtSubtotal.Text = subtotal.ToString("c");

                //Calculates the discount amount 
                discountAmount = subtotal * discountPercent;

                //Calculates the invoice total
                invoiceTotal = subtotal - discountAmount;

                //Rounds the discount amount and invoice total to 2 decimal places
                discountAmount = Math.Round(discountAmount, 2);
                invoiceTotal = Math.Round(invoiceTotal, 2);

                //Counts the number of invoices
                numberOfInvoices++;

                //Sums the invoice totals
                totalOfInvoices += invoiceTotal;

                //Calculates average of invoices
                invoiceAverage = totalOfInvoices / numberOfInvoices;

                //Returns the smallest invoice total and places it in a variable
                smallestInvoice = Math.Min(smallestInvoice, invoiceTotal);

                //Returns the largest invoice total and places it in a variable
                largerstInvoice = Math.Max(largerstInvoice, invoiceTotal);

                //Converts (decimal to string) and places the variables from above into their proper txtboxes
                txtDiscountPercent.Text = discountPercent.ToString("p1");
                txtDiscountAmount.Text = discountAmount.ToString("c");
                txtTotal.Text = invoiceTotal.ToString("c");

                //Converts (decimal to string) and places the variables from above into their proper txtboxes
                txtNumberOfInvoices.Text = numberOfInvoices.ToString();
                txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
                txtInvoiceAverage.Text = invoiceAverage.ToString("c");

                //Converts the smallest and largest invoices to a string and places them in their respective txtboxes
                txtSmallestInvoice.Text = smallestInvoice.ToString();
                txtLargestInvoice.Text = largerstInvoice.ToString();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + "Please try again." + "\n\n" + "Type of error encountered: " + ex.GetType().ToString(), "Error: Exception found.");
            }

                //Clears and Changes the focus back to subtotal txtbox
                txtEnterSubtotal.Text = "";
                txtEnterSubtotal.Focus();
        }

        
        //Clears variables
        private void btnClearTotals_Click(object sender, EventArgs e)
        {

            //Clears class variables
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            //Clears txtboxes
            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            txtEnterSubtotal.Focus();
        }

        //OK button event handler
        private void btnOK_Click(object sender, EventArgs e)
        {
            //Tests to see if text box name is blank or not, if it is then an error message is displayed
            if (txtEnterName.Text == "")
            {
                //Displayes error message and changes focus to name textbox
                MessageBox.Show("Name cannot be blank. Please re-enter.", "Entry Error");
                txtEnterName.Focus();
            }

            //Enables controls if text box is not blank
            else
            {
                //Dynamicly enables subtotal txt and lbl
                lblEnterSubtotal.Enabled = true;
                txtEnterSubtotal.Enabled = true;
                txtEnterSubtotal.Focus();
            }
        }

        //Closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
