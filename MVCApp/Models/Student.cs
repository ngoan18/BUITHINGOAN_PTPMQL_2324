using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCApp.Models
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Lop { get; set; }
        public string Khoa { get; set; }
    }
}