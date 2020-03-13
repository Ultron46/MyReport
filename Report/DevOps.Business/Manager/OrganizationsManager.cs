using DevOps.Business.Interfaces;
using DevOps.Data.Interfaces;
using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps.Business.Manager
{
    public class OrganizationsManager : IOrganizationsManager
    {
        private IOrganizationsDataRepository _organizationsDataRepository;

        public OrganizationsManager(IOrganizationsDataRepository organizationsDataRepository)
        {
            _organizationsDataRepository = organizationsDataRepository;
        }

        public List<Organisation> GetOrganisations()
        {
            return _organizationsDataRepository.GetOrganisations();
        }
    }
}
