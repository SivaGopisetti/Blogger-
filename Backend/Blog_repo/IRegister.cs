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
    }
}
