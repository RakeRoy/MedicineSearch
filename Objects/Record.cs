using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Record
    {
        public int RecID { get; set; }
        public DateTime RecDateTime { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
