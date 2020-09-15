using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Medicine
    {
        public int MedID { get; set; }
        public string MedName { get; set; }
        public string ExpTime{ get; set; }
        public string Formula{ get; set; }
        public string Manufacturer { get; set; }
        public int TypeID { get; set; }
        public int SymptomID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
