using HelloWorldSample.Abstract;
using System;
using System.Configuration;

namespace HelloWorldSample.Implementation
{
    public class DbWriter : IDbWriter
    {
        /// <summary>
        /// validates connection string
        /// </summary>
        public bool ValidateConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                return false;
            }
            return true;
        }

        public bool Write(object message)
        {
            //write to DB code here
            return true;
        }
    }
}
