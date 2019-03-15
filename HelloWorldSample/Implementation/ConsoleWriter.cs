using HelloWorldSample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldSample.Implementation
{
    public class ConsoleWriter : IConsoleWriter
    {
        /// <summary>
        /// Writes a message to Console
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Write(object message)
        {
            try
            {
                Console.WriteLine(message.ToString());
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
