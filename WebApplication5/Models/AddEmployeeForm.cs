using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class AddEmployeeForm
    {
        [Required]
        public int employeeId { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string department { get; set; }
    }
}
