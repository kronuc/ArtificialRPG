using System.Collections.Generic;
using ArtificialRPG.Model.DTO;

namespace ArtificialRPG.Models.Responses
{
    public class MakeTurnResponse
    {
        public int GameId { get; set; }
        public CharacterDTO Enemy { get; set; }
        public CharacterDTO Character { get; set; }
        public List<CartDescriptionDTO> Cards { get; set; } 
    }
}
