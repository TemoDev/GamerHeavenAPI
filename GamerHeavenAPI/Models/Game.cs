using System.ComponentModel.DataAnnotations.Schema;

namespace GamerHeavenAPI.Models
{
    public class Game
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = "Games";
        public string Description { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public int AgeOfAdmission { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public int Amount { get; set; }
        public string Img { get; set; } = string.Empty;

        // Foreign keys
        [ForeignKey("ConsoleId")]
        public Console? Console { get; set; }
        public int ConsoleId { get; set; }
    }
}
