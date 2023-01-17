using AspNetCoreWebApiDemo.Models;
using AspNetCoreWebApiDemo.ViewModels;

namespace AspNetCoreWebApiDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeDbContext _context;
        public EmployeeService(EmployeeDbContext context)
        {
            Console.WriteLine("Inside Service class");
            _context = context;
        }

        public List<Employees> GetEmployeesList()
        {
            Console.WriteLine("Get aLL method");
            List<Employees> empList;
            try
            {
                empList = _context.Set<Employees>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return empList;
        }

        public Employees GetEmployeeDetailsById(int empid)
        {
            Employees employees= new Employees();
            try
            {
                employees = _context.Find<Employees>(empid);
            }
            catch (Exception) { throw; }
            return employees;
        }

        public ResponseModel DeleteEmployee(int empid)
        {
            ResponseModel model= new ResponseModel();
            try
            {
                Employees emp = GetEmployeeDetailsById(empid);
                if(emp != null)
                {
                    _context.Remove<Employees>(emp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Message = "Employee Deleted Successfuly";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Message = "Employee Not Found in the dataset";
                }
            }
            catch(Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Error : "+ex.Message;
            }
            return model;
        }


        public ResponseModel SaveEmployee(Employees employeeModel)
        {
            ResponseModel model= new ResponseModel();
            try
            {
                Employees emp = GetEmployeeDetailsById(employeeModel.EmployeeId);
                if(emp != null)
                {
                    emp.EmployeeFirstName = employeeModel.EmployeeFirstName;
                    emp.EmployeeLastName = employeeModel.EmployeeLastName;
                    emp.Salary = employeeModel.Salary;
                    emp.Designation= employeeModel.Designation;
                    _context.Update<Employees>(emp);
                    model.Message = "Employee Updated Successfully";
                }
                else
                {
                    _context.Add<Employees>(employeeModel);
                    model.Message = "Employee Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch(Exception ex )
            {
                model.IsSuccess = false;
                model.Message="Error : "+ex.Message;
            }
            return model;
        }
    }
}
