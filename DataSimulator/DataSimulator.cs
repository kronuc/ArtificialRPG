using System;
using System.Collections.Generic;
using AutoBogus;

namespace DataSimulator
{
    public class DataSimulator
    {
        public int GetGameId()
        {
            return AutoFaker.Generate<int>();
        }

        public List<object> GetCards()
        {
            return AutoFaker.Generate<List<object>>();
        }
    }
}
