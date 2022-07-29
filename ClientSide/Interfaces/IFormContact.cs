using System;
using System.ComponentModel.DataAnnotations;

namespace ClientSide.Interfaces
{
    public interface IFormContact 
    {
        public string? Email { get; set; }
        public string? Message { get; set; }
    }

}

