using System.ComponentModel.DataAnnotations;
namespace Webmvc.Models;
public class Person
{
    [Key]
    public string Name { get; set; }
    public int tuoi { get; set; }
    public string Diachi { get; set; }
}