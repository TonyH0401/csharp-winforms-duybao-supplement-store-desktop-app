using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals_Project
{
    public class Account
    {
        public Account(string id, string fname, string lname, string email, string phone, string address)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public String id { get; set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String email { get; set; }
        public String phone { get; set; }
        public String address { get; set; }

    }
}
