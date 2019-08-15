using AutoMapper;
using Newtonsoft.Json;
using ReveEFAccess;
using ReveModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveMDMap
{
    public class CustomerMapProfile :Profile
    {
        public CustomerMapProfile()
        {
            CreateMap<Customer, RMCustomer>();
                //.ForMember(d => d.FirstName, opt => opt.MapFrom(s => JsonConvert.DeserializeObject<List<string>>(s.FirstName)))
                //.ReverseMap()
                //.ForMember(d => d.FirstName, opt => opt.MapFrom(s => JsonConvert.SerializeObject(s.FirstName))); 
        }
    }
}
