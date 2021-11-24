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
        
    }
    public class InsertTitleAndContentClass
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
    public class DeletingUserByGivingIdClass
    {
        public int id { get; set; }
    }
    public class UpdateContentAndTitleClass
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }
    }
    public class DeletingBlogByGivingIdClass
    {
        public int id { get; set; }
    }
    public class GettingBlogByUsingIdClass
    {
        //public string Title { get; set; }
        //public string Content { get; set; }
        public int id { get; set; }
    }
    public class GettingUserDetailsOfTheBlogClass
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int id { get; set; }

    }
    public class ResettingThePasswordClass
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
    public class EditingAllTheFieldOfUserClass
    {
        public string EmailId { get; set; }

        public string Password { get; set; }
        public int Id { get; set; }
        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
