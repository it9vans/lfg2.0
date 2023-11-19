using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LifeGuides.Models;

public class TableTest
{

    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set;}
    public int ordersCount { get; set; }

    [Column(TypeName = "date")]
    public DateOnly creationDate { get; set; }

}