using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Record
    {
        public int GetMaxID()
        {
            return new DAL.Record().GetMaxID();
        }
        public DataTable formload()
        {
            return new DAL.Record().formload();
        }

        public DataTable SearchByName(string Medicine)
        {
            return new DAL.Record().SerachByName(Medicine);
        }

        public DataTable SearchByDate(DateTime dateTime)
        {
            return new DAL.Record().SerachByDate(dateTime);
        }
    }
}
