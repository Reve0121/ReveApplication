
using ReveBusinessLogic;
using ReveModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ReveApplication.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : BaseController
    {
        private BLCustomer blCustomer = new BLCustomer();
        
        [HttpGet]
        [Route("allCustomer")]
        public async Task<HttpResponseMessage> GetAllCustomer()
        {
            return Return(await blCustomer.GetAllRMCustomer());
        }

        [HttpGet]
        [Route("getCustomerById/{id}")]
        public async Task<HttpResponseMessage> GetCustomerByIdAsync(int id)
        {
            return Return(await blCustomer.GetCustomerById(id));
        }
    }
}
