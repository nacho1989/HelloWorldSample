using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSample.Abstract
{
    public interface IDbWriter : IWriter
    {
        //can have more specific behaviors in the future
        bool ValidateConnectionString();
    }
}
