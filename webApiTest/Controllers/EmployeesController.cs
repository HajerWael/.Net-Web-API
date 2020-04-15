using System;
using System.Web.Http;
using System.Net.Http;
using webApiTest.Models;
using System.Collections.Generic;

namespace webApiTest.Controllers
{
    public class EmployeesController : ApiController
    {
        static List<Employee> emps = new List<Employee>{
            new Employee { Id = 1 , name = "Emp -1-" , age = 20 },
            new Employee { Id = 2 , name = "Emp -2-" , age = 29 },
            new Employee { Id = 3 , name = "Emp -3-" , age = 32 },
            new Employee { Id = 4 , name = "Emp -4-" , age = 36 }
        };

        public List<Employee> Get(){
            return emps;
        }
    }
}
