using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestContact_CQS.WebApp.Models.Forms
{
#nullable disable
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        [StringLength(384)]
        [DisplayName("Email :")]
        public string Email { get; set; }
        [Required]
        [StringLength(20,MinimumLength =8)]
        [DisplayName("Mot de Passe :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
