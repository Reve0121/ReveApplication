using ReveEFAccess;
using ReveModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveBusinessLogic
{
    public class BLBase
    {
        protected revedatabase db = new revedatabase();

        protected ResultModel<T> Success<T>(T data ,string message = "success")
        {
            return new ResultModel<T> { Message = message, IsSuccess = true, Data = data };
        }

        protected ResultModel<T> Error<T>(string message = "failure")
        {
            return new ResultModel<T> { Message = message, IsSuccess = false };
        }
    }
}
