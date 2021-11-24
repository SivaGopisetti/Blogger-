using System;
using System.Collections.Generic;
using System.Text;
using SqlConnectionClass;
namespace Blog_repo
{
    public interface IRegister
    {

        bool Registration(BlogModelClass blogRegister);

        bool Login(LoginClass loginClass);
        string ForgotPassword(string  _email);
        bool InsertDataTitleAndContent(InsertTitleAndContentClass insertTitleAndContentClass);
         bool DeleteUserById( DeletingUserByGivingIdClass deletingUserByGivingId);
        bool UpdateBlogWithContentAndTitle(UpdateContentAndTitleClass updateContentAndTitleClass);
        bool DeleteBlogById(DeletingBlogByGivingIdClass deletingBlogByGivingIdClass);
        bool GettingBlogById(GettingBlogByUsingIdClass gettingBlogByUsingIdClass);
        IEnumerable<BlogModelClass> GettingUserDetails();
        bool ResetPassword(ResettingThePasswordClass resettingThePasswordClass);
        bool EditingTheUserDetails(EditingAllTheFieldOfUserClass editingAllTheFieldOfUserClass);
    }
}
