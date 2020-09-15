using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User
    {
        public int ULogin(Objects.User obj)
        {
            return new DAL.User().ULogin(obj);
        }
        public int URegistration(Objects.User obj)
        {
            return new DAL.User().URegistration(obj);
        }
        public int GetMaxID()
        {
            return new DAL.User().GetMaxID();
        }
    }
}
