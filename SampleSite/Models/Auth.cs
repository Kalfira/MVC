using System.ComponentModel.DataAnnotations;
namespace SampleSite.Models
{
    public class Auth
    {
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}