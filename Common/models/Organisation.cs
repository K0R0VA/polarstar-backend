using System.ComponentModel.DataAnnotations;

namespace Common.models
{
    public class Organisation
    {
        public int Id { get; set; }
        [Required]
        public string Inn { get; set; }
        [Required]
        public string Kpp { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string MailAddress { get; set; }
    }
}