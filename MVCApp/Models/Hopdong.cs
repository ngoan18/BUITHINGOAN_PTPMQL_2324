using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCApp.Models;
public class Hopdong
{
    [Key]
    public string Mahp{ get; set; }
    public string Tenhp{ get; set; }
    public string Madaily { get; set; }
    [ForeignKey("Madaily")]
    public Daily? Daily { get; set; }
}