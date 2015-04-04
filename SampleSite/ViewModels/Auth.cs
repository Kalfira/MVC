using System.ComponentModel.DataAnnotations;
namespace SampleSite.ViewModels
{
    public class Auth
    {
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public string Test { get; set; }

    }
}