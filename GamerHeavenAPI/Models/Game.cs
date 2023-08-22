using System.ComponentModel.DataAnnotations.Schema;

namespace GamerHeavenAPI.Models
{
    public class Game
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public int AgeOfAdmission { get; set; }
        public string Publisher { get; set; }
        public int Amount { get; set; }
        public string Img { get; set; }

        // Foreign keys
        [ForeignKey("ConsoleId")]
        public Console? Console { get; set; }
        public int ConsoleId { get; set; }
    }
}
