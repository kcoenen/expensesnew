using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses
{
    public class Order_lines
    {
        Int32 order_line_id, order_id, cost_id;
        double price;
        DateTime date;
        String costname;

        public Order_lines()
        {

        }

        public int morder_line_id
        {
            get
            {
                return order_line_id;
            }
            set
            {
                order_line_id = value;
            }
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

        public String mcostname
        {
            get
            {
                return costname;
            }
            set
            {
                costname = value;
            }
        }

        public double mprice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
