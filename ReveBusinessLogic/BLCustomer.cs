using AutoMapper;
using ReveModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveBusinessLogic
{
    public class BLCustomer : BLBase
    {
        public async Task<ResultModel<List<RMCustomer>>> GetAllRMCustomer()
        {
            var customer = await db.Customers.ToListAsync();
            if (customer != null && customer.Count > 0)
            {
                return Success(Mapper.Map<List<RMCustomer>>(customer.OrderBy(r => r.CustomerID).ThenBy(r => r.FirstName)));
            }
            else
            {
                return Error<List<RMCustomer>>("No Customer template");
            }
        }

        public async Task<ResultModel<RMCustomer>> GetCustomerById(int id)
        {
            var customer = await db.Customers.FirstOrDefaultAsync(r => r.CustomerID == id);
            if(customer != null)
            {
                var result = Mapper.Map<RMCustomer>(customer);
                return Success(result);
            }
            else
            {
                return Error<RMCustomer>("No Customer");
            }
        }

        public async Task<ResultModel<RMCustomer>> CreateCustomer(RMCustomer rmCustomer)
        {
            rmCustomer.ModifiedDate = DateTime.Now;
            var entity = Mapper.Map<ReveEFAccess.Customer>(rmCustomer);
            db.Customers.Add(entity);
            await db.SaveChangesAsync();
            rmCustomer.CustomerID = entity.CustomerID;

            //CacheData.Cache_Stages = null;
            return Success(rmCustomer);

        }

        public async Task<ResultModel<RMCustomer>> UpdateCustomer(int id)
        {
            var customer = await db.Customers.FirstOrDefaultAsync(r => r.CustomerID == id);
            if (customer != null)
            {
                var result = Mapper.Map<RMCustomer>(customer);
                return Success(result);
            }
            else
            {
                return Error<RMCustomer>("No Customer");
            }
        }

    }
}
