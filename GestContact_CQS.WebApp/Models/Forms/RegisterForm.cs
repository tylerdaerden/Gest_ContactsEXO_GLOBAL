using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestContact_CQS.WebApp.Models.Forms
{
    public class RegisterForm
    {
        [Required]
        [StringLength(50,MinimumLength =1)]
        [DisplayName("Nom :")]
    }
}
