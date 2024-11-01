using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSystem.DAL
{
    public class VisitDAL
    {
        private readonly DataHelper databaseConnection;

        public VisitDAL()
        {
            this.databaseConnection = new DataHelper();
        }

        public async Task<bool> InsertVisitInformation()
        {
            return true;
        }
    }
}
