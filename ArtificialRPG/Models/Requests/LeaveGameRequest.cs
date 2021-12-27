using System.ComponentModel.DataAnnotations;

namespace ArtificialRPG.Models.Requests
{
    public class LeaveGameRequest
    {
        [Required]
        public int GameId { get; set; }
    }
}
