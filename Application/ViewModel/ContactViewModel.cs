using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel;
public class ContactViewModel
{
    [Required(ErrorMessage = "{0} field is required")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "{0} field must contain between {2} and {1} characters")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "{0} field is required")]
    [RegularExpression(@"^[0-9]{4,5}(?:-)[0-9]{4}$", ErrorMessage = "{0} field is not a valid phone number")]
    [StringLength(20, MinimumLength = 7, ErrorMessage = "{0} field must contain between {2} and {1} characters")]
    public required string Phone { get; set; }

    [Required(ErrorMessage = "{0} field is required")]
    [EmailAddress(ErrorMessage = "{0} field is not a valid email")]
    [StringLength(255, MinimumLength = 3, ErrorMessage = "{0} field must contain between {2} and {1} characters")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "{0} field is required")]
    [Range(11, 99, ErrorMessage = "DDD Id field must contain a value between {1} and {2}")]
    public int DddId { get; set; }
}
