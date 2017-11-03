using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Calculator
    {
        public decimal CalculatePostageCost(decimal price)
        {
            decimal _postageCost;

            if (price <= 0)
                throw new InvalidOperationException("The price of a video cannot be 0 or below");

            //If price is 30$or more, postage is free!
            if (price > 30)
            {
                _postageCost = 0;
            }
            else
            {
                _postageCost = price * 0.2m;
            }

            return _postageCost;
        }
    }
}
