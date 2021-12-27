using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtificialRPG.Model.DTO;
using ArtificialRPG.Model.Services.Abstraction;
using AutoBogus;

namespace ArtificialRPG.Model.Services.Implementation
{
    public class GameService : IGameService
    {
        public int CreateGame()
        {
            return AutoFaker.Generate<int>();
        }

        public void LeaveGame(int gameId)
        {
        }

        public void MakeTurn(int gameId)
        {
        }

        public List<CartDescriptionDTO> GetCartDescriptions(int gameId)
        {
            var result = new List<CartDescriptionDTO>();
            for (int i = 0; i < 4; i++)
                result.Add(AutoFaker.Generate<CartDescriptionDTO>());
            return result;
        }

        public CharacterDTO GetCharacter(int gameId)
        {
            var result = AutoFaker.Generate<CharacterDTO>();
            return result;
        }

        public CharacterDTO GetEnemy(int gameId)
        {
            var result = AutoFaker.Generate<CharacterDTO>();
            return result;
        }
    }
}
