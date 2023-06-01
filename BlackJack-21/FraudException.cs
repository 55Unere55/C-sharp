using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_21
{
    public class FraudException: Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)
            :base(message) { }

    }
}
