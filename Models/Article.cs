using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LifeGuides.Models;

public class Article
{
    [Key]
    public int id { get; set; }

    [StringLength(50, MinimumLength = 3, ErrorMessage = "Введите название длиной от 3 до 50 символов")]
    public string title { get; set; }

    [StringLength(100, MinimumLength = 3, ErrorMessage = "Введите описание длиной от 3 до 50 символов")]
    public string description { get; set; }


    public string text { get; set; }

    
    public int authorId { get; set; }
    public User? author { get; set; }
    

    [Column(TypeName = "timestamp")]
    public DateTime uploadDate { get; set; } = DateTime.Now;
    public int likesId { get; set; }
    public int dislikesId { get; set; }


}