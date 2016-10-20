namespace JokesApi.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        public string Email { get; set; }
    }
}
