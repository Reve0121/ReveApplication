using Newtonsoft.Json;
using ReveModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ReveApplication.Controllers
{
    public class BaseController : ApiController
    {
        [NonAction]
       protected HttpResponseMessage Return<T>(ResultModel<T> obj)
        {
            HttpResponseMessage response = this.GetResponseMessage(obj,HttpStatusCode.OK,true);
            return response;
        }
        [NonAction]
        protected HttpResponseMessage Success(object data = null,string message = "success")
        {
            var obj = new ResultModel<object> { Message = message, IsSuccess = true, Data = data };
            HttpResponseMessage response = this.GetResponseMessage(obj, HttpStatusCode.OK, true);
            return response;
        }

        [NonAction]
        protected HttpResponseMessage Error(string message = "failue")
        {
            var obj = new ResultModel<object>
            {
                Message = message,
                IsSuccess = false
            };
            HttpResponseMessage response = this.GetResponseMessage(obj, HttpStatusCode.BadRequest, true);
            return response;
        }

        [NonAction]
        public HttpResponseMessage GetResponseMessage(object data,HttpStatusCode code,bool compelJson)
        {
            HttpResponseMessage response = this.Request.CreateResponse(code);
            string result;
            if(data is string || data is char)
            {
                result = compelJson ? JsonConvert.SerializeObject(new { data = data.ToString() }) : data.ToString();
            }
            else
            {
                result = JsonConvert.SerializeObject(data);
            }
            response.Content = new StringContent(result, Encoding.GetEncoding("UTF-8"), "application/json");
            return response;
        }

       
    }
}