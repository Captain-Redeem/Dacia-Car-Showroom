using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaciaCarShowroom
{
    class Quote
    {

        public double CalculateQuotePrice(double listPrice)
        {
            return listPrice - 250;
        }

        public double CalculateMonthlyPayment(double listPrice)
        {
            return CalculateQuotePrice(listPrice) * 0.025;
        }
    }
}