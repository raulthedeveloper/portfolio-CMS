using System;
namespace ClientSide.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Image { get; set; }

        public string[]? ScreenShots { get; set; }
    }
}

