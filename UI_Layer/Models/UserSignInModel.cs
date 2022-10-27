using System.ComponentModel.DataAnnotations;

namespace UI_Layer.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını boş geçmeyin")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Password { get; set; }
    }
}
