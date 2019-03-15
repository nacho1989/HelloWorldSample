using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSample.Abstract
{
    public interface IWriter
    {
        bool Write(object message);
    }
}
