using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIocTest.Models
{
    public class UserInfo
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Salary { get; set; }
    }
}