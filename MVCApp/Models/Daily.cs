using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp.Models;
public class Daily
{
    [Key]
    public string Madaily { get; set; }
    public string Tendaily { get; set; }
    public string Diachi { get; set; }
    public string Nguoidaidien { get; set; }
    public string SDT { get; set; }
    
}