using System.ComponentModel.DataAnnotations;
namespace Demo.Models;
public class Person
{ 
    [Key]
    public string PersonID { get; set; }
    public string FullName { get; set;}
    public string Email { get; set;}
    public string Address { get; set;}
}