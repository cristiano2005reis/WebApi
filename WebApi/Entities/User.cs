using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Entities
{
    public class User
    {
        public Int64 UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}