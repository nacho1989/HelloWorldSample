using HelloWorldSample;
using HelloWorldSample.Abstract;
using HelloWorldSample.Implementation;
using NUnit.Framework;
using System;
using System.Configuration;

namespace HelloWordSample.Tests
{
    [TestFixture]
    public class HelloWorldTests : Base
    {        
        [TestCase("Hello World")]
        public void Write_Hello_World(string message)
        {
            var whereToWriteMessage = ConfigurationManager.AppSettings["WriteMessageTo"];
            Assert.IsTrue(!string.IsNullOrEmpty(whereToWriteMessage));

            Enum.TryParse<WhereToWrite>(whereToWriteMessage, out var parsedValue);
            Assert.IsTrue(parsedValue != WhereToWrite.NotSpecified);

            switch (parsedValue)
            {
                case WhereToWrite.DataBase :
                    IDbWriter _dbWriter = Factory.Create<DbWriter>();
                    Assert.IsTrue(_dbWriter.ValidateConnectionString() == true);
                    Assert.IsTrue(_dbWriter.Write(message) == true);
                    break;
                case WhereToWrite.Console:
                    IConsoleWriter _consoleWriter = Factory.Create<ConsoleWriter>();
                    Assert.IsTrue(_consoleWriter.Write(message) == true);
                    break;
                default:
                    Console.WriteLine("WhereToWrite Configuration Not specified");
                    break;

            }           
        }
    }
}
