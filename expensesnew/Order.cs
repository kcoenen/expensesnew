using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses
{
    public class Order
    {
        Int32 order_id, partner_id;
        String name;
        DateTime date;

        public Order()
        {

        }

        public int morder_id
        {
            get
            {
                return order_id;
            }
            set
            {
                order_id = value;
            }
        }

        public int mpartner_id
        {
            get
            {
                return partner_id;
            }
            set
            {
                partner_id = value;
            }
        }

        public String mname
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

        public DateTime mdate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
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
