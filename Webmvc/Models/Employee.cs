using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Webmvc.Models;

public class Employee

{
    [Key]
    public string EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string Address { get; set; }
      public string CustomerId { get; set;}
        [ForeignKey("CustomerId")]
        public Customer?Customer { get; set; }
}