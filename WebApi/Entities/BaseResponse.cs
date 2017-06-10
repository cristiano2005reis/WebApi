using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Entities
{
    public class BaseResponse
    {
        public bool Success {get;set;}
        public string Message { get; set; }
    }
}