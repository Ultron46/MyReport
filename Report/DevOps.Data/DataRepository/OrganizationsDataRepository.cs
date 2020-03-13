using DevOps.Data.Interfaces;
using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Data.DataRepository
{
    public class OrganizationsDataRepository : IOrganizationsDataRepository
    {
        public List<Organisation> GetOrganisations()
        {
            using (DevOpsEntities db = new DevOpsEntities())
            {
                return db.Organisations.ToList();
            }
        }
    }
}
