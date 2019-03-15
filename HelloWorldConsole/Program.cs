using HelloWorldSample;
using HelloWorldSample.Abstract;
using HelloWorldSample.Implementation;
using System;
using System.Configuration;

namespace HelloWorldConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            string message = "Hello World";

            try
            {
                var whereToWriteMessage = ConfigurationManager.AppSettings["WriteMessageTo"];
                Enum.TryParse<WhereToWrite>(whereToWriteMessage, out var parsedValue);

                IConsoleWriter _consoleWriter = Factory.Create<ConsoleWriter>();
                WriteMessage(_consoleWriter, message);
                   
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error Occurred while Writing Message: {ex.Message}");
            }
            
        }

        private static bool WriteMessage(IWriter Writer, object message)
        {
            return Writer.Write(message);
        }
    }
}
