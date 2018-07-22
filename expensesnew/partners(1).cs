using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses
{
    class Partners
    {
        private Int32 partner_id, city_id;
        private string naam, street, email, callname;

        public Partners()
        {
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

        public string mname
        {
            get
            {
                return naam;
            }
            set
            {
                naam = value;
            }
        }

        public string returnname
        {
            get
            {
                return naam;

            }
        }

    }
}
