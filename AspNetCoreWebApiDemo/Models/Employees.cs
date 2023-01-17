using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApiDemo.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Salary { get; set; }
        public string Designation { get; set;}


    }
}
