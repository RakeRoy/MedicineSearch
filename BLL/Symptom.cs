using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{

    public class Symptom
    {
        DataTable dt;
        public int GetMaxID()
        {
            return new DAL.Symptom().GetMaxID();
        }

        public int InsertData(Objects.Symptom symp)
        {
            return new DAL.Symptom().InsertData(symp);
        }
    }
}
