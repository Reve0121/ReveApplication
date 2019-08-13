using ReveEFAccess;
using ReveModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ReveApplication.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        protected revedatabaseEntities db = new revedatabaseEntities();

        [HttpGet]
        [Route("allCustomer")]
        public async Task<RMCustomer> getAllCustomer()
        {
            return await db.Customers.ToListAsync();
        }
    }
}
