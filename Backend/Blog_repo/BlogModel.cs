namespace Blog_repo
{
    public class BlogModelClass
    {
        
        public string EmailId { get; set; }

      
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class LoginClass
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
    public class ForgotPasswordClass
    {
        public string EmailId { get; set; }
        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }

    }
    public class InsertTitleAndContentClass
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

}
