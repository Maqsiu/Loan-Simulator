using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loan_simulator
{
    public class CInterestRate
    {
        float insRateDev;

        // Constructor to initialize the interest rate
        public CInterestRate(float insRate) 
        {
        this.insRateDev = insRate;
        }
         public float retRate()
        {
            return insRateDev;
        }
     
    }
}
