using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Finals_Project
{
    public class Store
    {
        public Store()
        {
            this.id = "";
            this.name = "";
            this.location = "";
            this.tax = 0;
        }

        public Store(String _id, String _name, String _location, String _tax)
        {
            this.id = _id;
            this.name = _name;
            this.location = _location;
            this.tax = int.Parse(_tax.ToString().Trim());
        }

        public String id { get; set; }
        public String name { get; set; }
        public String location { get; set; }
        public int tax { get; set; }

    }
}
