using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Entities;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class UserService
    {
        public BaseResponse DeleteById(int id)
        {
            BaseResponse response = new BaseResponse();

            try
            {
                using (UserRepository repository = new UserRepository())
                {
                    repository.DeleteById(id);
                }

                response.Success = true;
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Message = (e.InnerException != null)? e.Message + " - " + e.InnerException.Message : e.Message;
            }

            return response;
        }

        public BaseResponse GetUserById(int id)
        {
            BaseResponse response = new BaseResponse();

            try
            {
                using (UserRepository repository = new UserRepository())
                {
                    repository.GetUserbyId(id);
                }

                response.Success = true;
            }
            catch (Exception e)
            {
                response.Success = false;
                response.Message = (e.InnerException != null) ? e.Message + " - " + e.InnerException.Message : e.Message;
            }

            return response;
        }
    }
}