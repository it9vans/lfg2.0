using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LifeGuides.Models;

public class Book
{

    [Key]
    public int id { get; set; }
    
    [NotNull]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Введите название длиной от 3 до 50 символов")]
    public string title { get; set; }

    public int authorId { get; set;}

    [NotNull]
    public BooksAuthor author { get; set; }




}