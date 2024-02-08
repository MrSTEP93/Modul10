using System;
using static ConsoleHelper_50.Helper_50;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Modul10.Final2
{
    public interface ILogger
    {
        void Info(string message);
        void Event(string message);
        void Error(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            WriteLn(message, ConsoleColor.Red);
        }

        public void Info(string message)
        {
            WriteLn(message, ConsoleColor.White);
        }

        public void Event(string message)
        {
            WriteLn(message, ConsoleColor.Blue);
        }
    }

    public class FileLogger : ILogger
    {
        private FileInfo logFile;

        public FileLogger(string logFilePath)
        {
            logFile = new FileInfo(logFilePath);
        }

        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Event(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }
    }

}
