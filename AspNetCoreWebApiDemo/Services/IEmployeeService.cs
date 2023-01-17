using AspNetCoreWebApiDemo.Models;
using AspNetCoreWebApiDemo.ViewModels;

namespace AspNetCoreWebApiDemo.Services
{
    public interface IEmployeeService
    {
        
        public List<Employees> GetEmployeesList();
        
        public Employees GetEmployeeDetailsById(int empid);
        
        public ResponseModel SaveEmployee(Employees employeeModel);

        public ResponseModel DeleteEmployee(int empid);
    }
}
