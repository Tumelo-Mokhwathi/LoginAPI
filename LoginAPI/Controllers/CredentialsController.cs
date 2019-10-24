using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;

namespace LoginAPI.Controllers
{
    public class CredentialsController : ApiController
    {
        public IEnumerable<Credential> Get()
        {
            using(CredentialsEntities entities = new CredentialsEntities())
            {
                return entities.Credentials.ToList();
            }
        }

        public Credential Get(string username)
        {
            using(CredentialsEntities entities = new CredentialsEntities())
            {
                return entities.Credentials.FirstOrDefault(e => e.Username == username);
            }
        }

    }
}