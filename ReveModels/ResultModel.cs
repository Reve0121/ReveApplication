using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveModels
{
    public class ResultModel<T>
    {
        private bool _IsSuccess = true;
        [JsonProperty("isSuccess")]
        public bool IsSuccess
        {
            get{ return _IsSuccess; }
            set
            {
                _IsSuccess = value;
            }
        }

        [JsonProperty("data")]
        public T Data { get; set; }

        private string _Message = "";
        [JsonProperty("message")]
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }

        }
    }
}
