
using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }

        [Range(1, 5, ErrorMessage = "Please select a rating")]
        public int Rating { get; set; }
    }
}
