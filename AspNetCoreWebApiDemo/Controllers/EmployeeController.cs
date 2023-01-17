using AspNetCoreWebApiDemo.Models;
using AspNetCoreWebApiDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService service)
        {
            Console.WriteLine("Inside Controller");
            _employeeService = service;
        }


        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                var employees = _employeeService.GetEmployeesList();
                if (employees == null)
                {
                    return NotFound();
                }
                return Ok(employees);
            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }


        [HttpGet]
        [Route("[action]/id")]
        public IActionResult GetEmployeeById(int Id)
        {
            try
            {
                var employee = _employeeService.GetEmployeeDetailsById(Id); 
                if(employee == null) return NotFound();
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }


        [HttpPost]
        [Route("[action]")]
        public IActionResult SaveEmployees(Employees employeeModel)
        {
            try
            {
                var model = _employeeService.SaveEmployee(employeeModel);
                return Ok(model); 
            }
            catch(Exception ex) { return BadRequest(); }
        }



        [HttpDelete]
        [Route("[action]")]
        public IActionResult DeleteEmployee(int Id)
        {
            try
            {
                var employee = _employeeService.DeleteEmployee(Id);
                return Ok(employee);
            }
            catch(Exception ex) { return BadRequest(); }
        }
    }
}
