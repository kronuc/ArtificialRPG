using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ArtificialRPG.Model.DTO;
using AutoBogus;

namespace ArtificialRPG.Model.Services.Abstraction
{
    public interface IGameService
    {
        public int  CreateGame();

        public void LeaveGame(int gameId);

        public void MakeTurn(int gameId);

        public List<CartDescriptionDTO> GetCartDescriptions(int gameId);

        public CharacterDTO GetCharacter(int gameId);
        
        public CharacterDTO GetEnemy(int gameId);
    }
}
