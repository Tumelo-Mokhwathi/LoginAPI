using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace LoginAPI.Controllers
{
    public class DetailsController : ApiController
    {
        public IEnumerable<Detail> Get()
        {
            using (CredentialsEntities entities = new CredentialsEntities())
            {
                return entities.Details.ToList();
            }
        }

        public Detail Get(int id)
        {
            using (CredentialsEntities entities = new CredentialsEntities())
            {
                return entities.Details.FirstOrDefault(e => e.IdNo == id);
            }
        }
    }
}