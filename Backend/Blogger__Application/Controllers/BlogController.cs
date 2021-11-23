using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_repo;

namespace Blog.Controller
{

    public class BlogController : ControllerBase
    {

        private readonly IRegister _register;


        public BlogController(IRegister registerservice)
        {
            _register = registerservice;
        }
        //register
        [HttpPost, Route("api/BlogController/Register")]
        ///{FirstName}/{LastName}/{EmailId}/{Password}/{ConfirmPassword}
        public bool Register(BlogModelClass _iregister)
        {
            if (_register.Registration(_iregister))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        //login
        [HttpGet,Route("api/BlogController/Login")]
        public bool LoginClass(LoginClass loginClass)
        {
            if(_register.Login(loginClass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //forget
        [HttpGet, Route("api/BlogController/ForgotPassword")]
        public bool ForgotPasswordClass(ForgotPasswordClass forgotPasswordClass)
        {
            if(_register.ForgotPassword(forgotPasswordClass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //insert
        [HttpPost, Route("api/BlogController/InsertDataTitleAndContent")]
        public bool InsertTitleAndContentClass(InsertTitleAndContentClass insertTitleAndContentClass)
        {
            if (_register.InsertDataTitleAndContent(insertTitleAndContentClass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

