using System.ComponentModel.DataAnnotations.Schema;

namespace GamerHeavenAPI.Models
{
    public class Controller
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = "Controllers";
        public string Manufacturer { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;
        public int Amount { get; set; } 

        // Foreign keys which point to the console
        [ForeignKey("ConsoleId")]
        public Console? Console { get; set; }
        public int ConsoleId { get; set; }

    }
}
