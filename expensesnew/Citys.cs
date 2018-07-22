using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenses
{
    public class Citys

    {
        private int city_id;
        private string name, zip_code;

        public Citys()
        {
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

        public String mzip_code
        {
            get
            {
                return zip_code;
            }
            set
            {
                zip_code = value;
            }
        }

        public string returnname
        {
            get
            {
                return zip_code + " " + name;

            }
        }
    }
}
