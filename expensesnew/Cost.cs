using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses
{
    public class Cost
    {
        private int cost_id;
        private string name;

        public Cost()
        {
        }

        public int mcost_id
        {
            get
            {
                return cost_id;
            }
            set
            {
                cost_id = value;
            }
        }

        public string mname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string returnname
        {
            get
            {
                return name;

            }
        }
    }
}
