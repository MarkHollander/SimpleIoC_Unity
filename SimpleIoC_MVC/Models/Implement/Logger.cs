using System;
using SimpleIoC_MVC.Interface;

namespace SimpleIoC_MVC.Implement
{
    public class Logger : ILogger
    {
        public void LogInfo(string info)
        {
            Console.WriteLine("Write Real Log");
        }
    }
}