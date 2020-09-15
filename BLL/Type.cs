using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Type
    {
        public int GetMaxID()
        {
            return new DAL.Type().GetMaxID();
        }

        public int InsertData(Objects.Type type)
        {
            return new DAL.Type().InsertData(type);
        }
    }
}
