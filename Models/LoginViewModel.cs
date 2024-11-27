using System.ComponentModel.DataAnnotations;

namespace Final_project.Models
{
    public class LoginViewModel
    {
        
        
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        

    }
}
