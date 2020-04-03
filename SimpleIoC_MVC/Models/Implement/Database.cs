using System;
using SimpleIoC_MVC.Interface;

namespace SimpleIoC_MVC.Implement
{
    public class Database : IDatabase
    {
        public void Save(int orderId)
        {
            Console.WriteLine("Saved to real database");
        }
    }
}