using System;
using System.Collections.Generic;
using System.Text;

namespace SqlConnectionClass.Exceptions
{
    //adding exceptions by inheriting exception
    public class BlogException : Exception
    {
        public BlogException()
        {

        }

        public BlogException(string message) : base(message)
        {

        }

        public BlogException(string message, Exception innerEx) : base(message, innerEx)
        {

        }
    }
}