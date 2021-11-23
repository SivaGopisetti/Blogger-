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
        bool ForgotPassword(ForgotPasswordClass forgotPasswordClass);
        bool InsertDataTitleAndContent(InsertTitleAndContentClass insertTitleAndContentClass);
         bool DeleteUserById( DeletingUserByGivingIdClass deletingUserByGivingId);
        bool UpdateBlogWithContentAndTitle(UpdateContentAndTitleClass updateContentAndTitleClass);
        bool DeleteBlogById(DeletingBlogByGivingIdClass deletingBlogByGivingIdClass);
        bool GettingBlogById(GettingBlogByUsingIdClass gettingBlogByUsingIdClass);
        bool GettingUserDetails(GettingUserDetailsOfTheBlogClass gettingUserDetailsOfTheBlogClass);

    }
}
