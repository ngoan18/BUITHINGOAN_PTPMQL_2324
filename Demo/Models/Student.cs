using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Demo.Models;
public class Student
{
    [Key]
    public string MSV {get; set; }
    public string FullName {get; set; }
    public string Khoa {get; set; }
    public int Tuoi {get; set; }
    public string PersonID {get; set; }
    [ForeignKey ("PersonID")]
    public Person?Person {get; set; }
}