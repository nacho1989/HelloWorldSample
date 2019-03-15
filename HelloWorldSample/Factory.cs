using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSample
{
    public class Factory
    {
        public static T Create<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
