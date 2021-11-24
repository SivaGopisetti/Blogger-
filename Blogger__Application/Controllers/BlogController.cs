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
        public string ForgotPasswordClass(String _email)
        {
            return _register.ForgotPassword(_email);
           
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
        [HttpDelete, Route("api/BlogController/DeletingUserByGivingIdClass")]
        public bool DeletingUserByGivingIdClass(DeletingUserByGivingIdClass deletingUserByGivingId)
        {
            if (_register.DeleteUserById(deletingUserByGivingId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Update Content And Title
        [HttpGet, Route("api/BlogController/UpdateContentAndTitleClass")]
        public bool UpdateBlogWithContentAndTitle(UpdateContentAndTitleClass updateContentAndTitleClass)
        {
            if(_register.UpdateBlogWithContentAndTitle(updateContentAndTitleClass))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        //Deleting Blog Id
        [HttpDelete, Route("api/BlogController/DeletingBlogByGivingIdClass")]
        public bool DeleteBlogById(DeletingBlogByGivingIdClass deletingBlogByGivingIdClass)
        {
            if (_register.DeleteBlogById(deletingBlogByGivingIdClass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //get blog by id
        [HttpGet, Route("api/BlogController/GettingBlogByUsingIdClass")]
        public bool GettingBlogById(GettingBlogByUsingIdClass gettingBlogByUsingIdclass)
        {
            if (_register.GettingBlogById(gettingBlogByUsingIdclass))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        //GettingUserDetailsOfTheBlogClass
        [HttpGet, Route("api/BlogController/GettingUserDetailsOfTheBlogClass")]
        public IEnumerable<BlogModelClass> GettingUserDetails()
        {
            return _register.GettingUserDetails();
        }
        //ResettingThePasswordClass
        [HttpPatch, Route("api/BlogController/ResettingThePasswordClass")]
        public bool ResetPassword(ResettingThePasswordClass resettingThePasswordClass)
        {
            if (_register.ResetPassword(resettingThePasswordClass))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        [HttpPut, Route("api/BlogController/EditingAllTheFieldOfUserClass")]
        public bool EditingTheUserDetails(EditingAllTheFieldOfUserClass editingAllTheFieldOfUserClass)
        {
            if (_register.EditingTheUserDetails(editingAllTheFieldOfUserClass))
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

