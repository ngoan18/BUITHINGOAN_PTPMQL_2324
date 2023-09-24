using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCApp.Models;
public class Employee
{
    [Key]
    public string EmployeeId { get; set; }
    public string Name { get; set; }
    public string SDT { get; set;}
    public int Age { get; set; }
}