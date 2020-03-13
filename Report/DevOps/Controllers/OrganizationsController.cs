using DevOps.Business.Interfaces;
using DevOps.DataEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevOps.Controllers
{
    public class OrganizationsController : ApiController
    {
        private IOrganizationsManager _organizationsManager;

        public OrganizationsController(IOrganizationsManager organizationsManager)
        {
            _organizationsManager = organizationsManager;
        }

        public IHttpActionResult GetOrganizations()
        {
            List<Organisation> organisations = _organizationsManager.GetOrganisations();
            if(organisations == null)
            {
                return NotFound();
            }
            return Ok(organisations);
        }
    }
}
