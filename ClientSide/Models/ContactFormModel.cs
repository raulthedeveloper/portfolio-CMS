using System;
using System.ComponentModel.DataAnnotations;
using ClientSide.Interfaces;

namespace ClientSide.Models
{
    public class ContactFormModel : IFormContact
    {

        [Required]
        [EmailAddress]
        [StringLength(30, ErrorMessage = "Email is too long.")]
        public string? Email { get; set; }

  
        [Required]
        [StringLength(255, ErrorMessage = "Message can not be longer then 255 characters")]
        public string? Message { get; set; }
    }
}

