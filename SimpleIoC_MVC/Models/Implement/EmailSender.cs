using System;
using SimpleIoC_MVC.Interface;

namespace SimpleIoC_MVC.Implement
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(int userId)
        {
            Console.WriteLine("Send real email");
        }
    }
}