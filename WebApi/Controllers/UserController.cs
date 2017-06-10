using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using System.Web.Http;
using System.Web;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using WebApi.Services;

namespace WebApi.Controllers
{
    [RoutePrefix("user")]
    public class UserController: BaseController
    {
        [HttpPost]
        public IHttpActionResult GetUserById(int id)
        {
            try
            {
                UserService service = new UserService();
                service.GetUserById(id);

                return Ok();
            }

            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                UserService service = new UserService();
                service.DeleteById(id);

                return Ok();
            }

            catch(Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}