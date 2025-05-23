using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaciaCarShowroom
{
    public partial class frmQuote : Form
    {
        public frmQuote()
        {
            InitializeComponent();
        }

        Car car = new Car(); //Global Car Object

        private void radPetrol_CheckedChanged(object sender, EventArgs e)
        {
            car.Engine = "1.2 Petrol";
        }

        private void radDiesel_CheckedChanged(object sender, EventArgs e)
        {
            car.Engine = "1.6 Diesel";
        }

        private void radAmbiance_CheckedChanged(object sender, EventArgs e)
        {
            car.Trim = "Ambiance";
        }

        private void radMidnight_CheckedChanged(object sender, EventArgs e)
        {
            car.Trim = "Midnight";
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            //instantiating Quote and Customer classes
            Quote quote = new Quote();
            Customer customer = new Customer();

            //get the customer data
            customer.FirstName = txtFirstName.Text;
            customer.Surname = txtSurname.Text;

            //get the list price
            quote.CalculateQuotePrice(car.CalculateListPrice());

            //quote output
            string output = "Your name: " + customer.FirstName + " " + customer.Surname + "\n" +
                "Your car: Dacia Sandero, " + car.Engine + ", " + car.Trim + "\n" +
                "Basic List Price: £" + car.CalculateListPrice() + "\n" +
                "Special Quote price: £" + quote.CalculateQuotePrice(car.CalculateListPrice()) + "\n" +
                "Typical monthly payment: £" + quote.CalculateMonthlyPayment(car.CalculateListPrice());

            lblQuote.Text = output;
        }
    }
}
