using System.ComponentModel.DataAnnotations;

namespace Webmvc.Models;

public class Employee

{
    [Key]
    public string EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string Address { get; set; }
}