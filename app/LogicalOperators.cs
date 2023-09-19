using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class LogicalOperators
    {
        public bool And()
        {
            return (2 == 2) && (1 != 2);
        }

        public bool OR()
        {
            return (2 != 2) || (1 != 2);
        }

        public bool Not()
        {
            return !(2 == 3);
        }
    }
}