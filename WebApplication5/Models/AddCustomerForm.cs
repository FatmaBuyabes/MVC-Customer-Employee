using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class AddCustomerForm
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [EmailAddress]
        public string email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Phone]
        public string phone { get; set; }
    }
}
