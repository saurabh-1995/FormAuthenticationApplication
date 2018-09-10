using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormAuthApplication.DAL
{
    public class DataBaseOperations
    {
        public List<LoginCredentials> GetCredentials()
        {
            using (DBModel dBModel = new DBModel())
            {
                return (dBModel.tblFormAuthentication).ToList();
            }
        }
    }
}
