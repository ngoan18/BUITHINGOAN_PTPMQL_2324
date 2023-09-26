
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models;
public class Hethongphanphoi
{
    [Key]
    public string MaHTPP { get; set; }
    public string TenHTPP { get; set; }
}