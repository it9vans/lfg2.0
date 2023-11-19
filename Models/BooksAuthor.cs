using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LifeGuides.Models;

public class BooksAuthor
{

    [Key]
    public int id { get; set; }

    [StringLength(50, MinimumLength = 3, ErrorMessage = "Введите название длиной от 3 до 50 символов")]
    public string name { get; set; }

    public List<Book> books { get; set; } = new();

    



}