using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LifeGuides.Models;

public class Register
{

    [StringLength(25, MinimumLength = 3, ErrorMessage = "Введите никнейм длиной от 3 до 25 символов!")]
    [NotNull]
    public string nickname { get; set; }

    [RegularExpression(@"(^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+\.[a-zA-z]{2,3}$)", ErrorMessage = "Неправильный формат электронной почты")]
    [NotNull]
    public string email { get; set; }

    [StringLength(30, MinimumLength = 8, ErrorMessage = "Пароль слишком короткий!")]
    [RegularExpression(@"[A-Za-z]+", ErrorMessage = "В пароле отсутствуют буквы!")]
    [NotNull]
    public string password { get; set; }


}