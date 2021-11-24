using System;
using System.Data.SqlClient;
using SqlConnectionClass;
using SqlConnectionClass.Exceptions;
using Blog_repo;
using System.Collections.Generic;

namespace Blog_repo
{
    public class Register : IRegister
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        // private readonly IRegister register1;
        public Register()
        {
            _connection = new SqlConnection(SqlconnectionClass.ConnectionString);
        }
        public bool Registration(BlogModelClass blogRegister)
        {

            bool isSuccess = false;
            try
            {
                using (_command = new SqlCommand($"INSERT INTO dbo.RegistrationPage VALUES('" + blogRegister.FirstName + "','" +
                    blogRegister.LastName + "','" + blogRegister.EmailId + "','" + blogRegister.Password + "','" +
                    blogRegister.ConfirmPassword + "')", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    _command.ExecuteNonQuery();

                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }

            return isSuccess;
        }
        //login
        public bool Login(LoginClass loginClass)
        {


            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand($"SELECT * FROM dbo.RegistrationPage where  EmailId='{loginClass.EmailId}'", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (loginClass.Password.Equals(reader[3]))
                        {
                            isSuccess = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }


            return isSuccess;
        }
        //forgot password
        public bool ForgotPassword(ForgotPasswordClass forgotPasswordClass)
        {
            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand($"UPDATE dbo.RegistrationPage SET UserPassword= '" + forgotPasswordClass.UserPassword + "',ConfirmPassword='" + forgotPasswordClass.ConfirmPassword + "' WHERE  EmailId='" + forgotPasswordClass.EmailId + "'", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (forgotPasswordClass.EmailId.Equals(reader[3]))
                        {
                            isSuccess = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return isSuccess;
        }
        //insert data and title
        public bool InsertDataTitleAndContent(InsertTitleAndContentClass insertTitleAndContentClass)
        {
            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand($"insert into dbo.InsertTableForTitleAndContent values('" + insertTitleAndContentClass.Title + "','" + insertTitleAndContentClass.Content + "')", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    {
                        isSuccess = true;

                    }

                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return isSuccess;
        }
        //deletingUserByGivingId
        public bool DeleteUserById(DeletingUserByGivingIdClass deletingUserByGivingId)
        {
            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand($"delete from dbo.RegistrationPage where Id='" + deletingUserByGivingId.id + "' ", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    {
                        isSuccess = true;

                    }

                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return isSuccess;
        }
        //updateContentAndTitleClass
        public bool UpdateBlogWithContentAndTitle(UpdateContentAndTitleClass updateContentAndTitleClass)
        {
            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand($"UPDATE dbo.InsertTableForTitleAndContent SET Title= '" + updateContentAndTitleClass.Title + "',Content='" + updateContentAndTitleClass.Content + "' WHERE  Id='" + updateContentAndTitleClass.Id + "'", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (updateContentAndTitleClass.Id.Equals(reader[3]))
                        {
                            isSuccess = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return isSuccess;
        }
        //deletingBlogByGivingIdClass
        public bool DeleteBlogById(DeletingBlogByGivingIdClass deletingBlogByGivingIdClass)
        {
            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand($"delete from dbo.InsertTableForTitleAndContent where Id='" + deletingBlogByGivingIdClass.id + "' ", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    {
                        isSuccess = true;

                    }

                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return isSuccess;
        }
        //gettingBlogByUsingIdClass
        public bool GettingBlogById(GettingBlogByUsingIdClass gettingBlogByUsingIdClass)
        {
            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand("SELECT * FROM dbo.InsertTableForTitleAndContent where Id='" + gettingBlogByUsingIdClass.id + "' ", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    {
                        isSuccess = true;

                    }

                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return isSuccess;
        }
        //gettingUserDetailsOfTheBlogClass
        public bool GettingUserDetails(GettingUserDetailsOfTheBlogClass gettingUserDetailsOfTheBlogClass)
        {
            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand("SELECT FirstName,LastName,EmailId ,Id FROM dbo.RegistrationPage where Id='" + gettingUserDetailsOfTheBlogClass.id + "' ", _connection))
                
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    {
                        isSuccess = true;

                    }

                }
            }
            catch (Exception ex)
            {
                throw new BlogException(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return isSuccess;
        }

    }
}