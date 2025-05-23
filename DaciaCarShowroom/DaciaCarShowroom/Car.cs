using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaciaCarShowroom
{
    class Car
    {
        public string Engine
        {
            get;
            set;
        }

        public string Trim
        {
            get;
            set;
        }

        public double CalculateListPrice()
        {
            if (Engine == "1.2 litre Petrol")
            {
                if (Trim == "Ambiance")
                {
                    return 5995;
                }
                else //must be midnight trim
                {
                    return 6995;
                }
            }
            else //must be 1.6 diesel
            {
                if(Trim == "Ambiance")
                {
                    return 6495;
                }
                else //must be midnight trim
                {
                    return 7245;
                }
            }
        }
    }
}
