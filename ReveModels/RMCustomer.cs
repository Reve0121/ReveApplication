using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveModels
{
    public class RMCustomer
    {
        [JsonProperty("customerID")]
        public int CustomerID { get; set; }

        [JsonProperty("nameStyle")]
        public bool NameStyle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("FirstName")]
        [Required(ErrorMessage = "FirstName can't be null.")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
        [JsonProperty("salesPerson")]
        public string SalesPerson { get; set; }
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        
        //public string PasswordHash { get; set; }
        [JsonProperty("passwordSalt")]
        public string PasswordSalt { get; set; }
       
        //public System.Guid rowguid { get; set; }
       
        //public System.DateTime ModifiedDate
        //{
        //    get; set;
        //}
    }
}
