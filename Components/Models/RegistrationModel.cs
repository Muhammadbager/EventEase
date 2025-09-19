using System.ComponentModel.DataAnnotations;

namespace EventEase.App.Components.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        [StringLength(255, ErrorMessage = "Email is too long")]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Invalid phone number format")]
        [StringLength(20, ErrorMessage = "Phone number is too long")]
        public string? PhoneNumber { get; set; }

        [StringLength(500, ErrorMessage = "Comments are too long")]
        public string? Comments { get; set; }

        [Required(ErrorMessage = "Event selection is required")]
        public int EventId { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public bool IsConfirmed { get; set; } = false;
    }
}
