using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LifeGuides.Models;

public class User
{
    [Key]
    public int id { get; set; }

    [StringLength(50, MinimumLength = 3)]
    [NotNull]
    public string nickname { get; set; }

    [RegularExpression(@"(^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+\.[a-zA-z]{2,3}$)", ErrorMessage = "Invaild email")]
    [NotNull]
    public string email { get; set; }

    [StringLength(30, MinimumLength = 8), RegularExpression(@"[A-Za-z]+")]
    [NotNull]
    public string password { get; set; }

    [Column(TypeName = "timestamp without time zone")]
    [NotNull]
    public DateTime registrationDate { get; set; } = DateTime.Now;

    public int subscribesId { get; set; }
    public int subscribersId { get; set; }
    public List<Article> Articles { get; set; } = new();

}