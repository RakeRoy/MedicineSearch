using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Medicine
    {
        public int GetMaxID()
        {
            return new DAL.Medicine().GetMaxID();
        }

        public int InsertData(Objects.Medicine med)
        {
            return new DAL.Medicine().InsertData(med);
        }

        public DataTable formload(Objects.Medicine med)
        {
            return new DAL.Medicine().formload(med);
        }
        public DataTable GetTypeData()
        {
            return new DAL.Medicine().GetTypeData();
        }

        public DataTable GetUseData()
        {
            return new DAL.Medicine().GetUseData();
        }

        public DataTable formloadFormula (Objects.Medicine med, string formula)
        {
            return new DAL.Medicine().formloadFormula(med, formula);
        }

        public DataTable formloadName (Objects.Medicine med, string name)
        {
            return new DAL.Medicine().formloadName(med, name);
        }

        public DataTable formloadManufacturer(Objects.Medicine med, string manufacturer)
        {
            return new DAL.Medicine().formloadManufacturer(med, manufacturer);
        }

        public DataTable formloadSymptom(Objects.Medicine med, string symptom)
        {
            return new DAL.Medicine().formloadSymptom(med, symptom);
        }

        public int GetTypeID(string Type)
        {
            return new DAL.Medicine().GetTypeID(Type);
        }

        public int GetUseID(string Use)
        {
            return new DAL.Medicine().GetUseID(Use);
        }

        public void BuyMedicine(string Medicine, int Quantity)
        {
            new DAL.Medicine().BuyMedicine(Medicine, Quantity);
        }

        public int getPrice(string Medicine, int Quantity)
        {
            return new DAL.Medicine().getPrice(Medicine, Quantity);
        }

        public Objects.Medicine getRow(string Medicine)
        {
            return new DAL.Medicine().getRow(Medicine);
        }

        public int UpdateData(Objects.Medicine med)
        {
            return new DAL.Medicine().UpdateData(med);
        }

        public int DeleteData(string Medicine)
        {
            return new DAL.Medicine().DeleteData(Medicine);
        }
    }
}
