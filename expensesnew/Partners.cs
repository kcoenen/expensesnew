using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses
{
    public class Partners
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

        public int mcity_id
        {
            get
            {
                return city_id;
            }
            set
            {
                city_id = value;
            }
        }

        public string mstreet
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public string memail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string mcallname
        {
            get
            {
                return callname;
            }
            set
            {
                callname = value;
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
