using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace MyIocTest.Models
{
    public class IocService
    {
        public static object GetObject(string className)
        {
            IocDomain.className = className;
            return ConfigurationManager.GetSection("MyIocContainer/objects");
        }
    }
}