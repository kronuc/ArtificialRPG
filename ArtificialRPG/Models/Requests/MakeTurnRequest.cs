using System.ComponentModel.DataAnnotations;

namespace ArtificialRPG.Models.Requests
{
    public class MakeTurnRequest
    {
        [Required]
        public int GameId { get; set; }
        
        [Range(0, 3)]
        public int CardId { get; set; }
    }
}
