using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApi.Entities;

namespace WebApi.Contexts
{
    public class WebApiContext:PrionContext
    {
        public DbSet<User> users { get; set; }
    }
}