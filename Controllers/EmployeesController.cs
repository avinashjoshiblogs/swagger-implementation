using Microsoft.AspNetCore.Mvc;
using Calculator;

namespace SwaggerImplementation.Controllers
{
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<Employee> GetEmployees()
        {
            return new Employee();
        }
        [HttpPost("post")]
        public async Task<bool> SetEmployees(Employee employee)
        {
            return true;
        }
        [HttpPut("put")]
        public async Task<bool> PutEmployees(Employee employee)
        {
            return true;
        }
        [HttpDelete("delete")]
        public async Task<bool> deleteEmployees(int id)
        {
            return true;
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
    }
}
