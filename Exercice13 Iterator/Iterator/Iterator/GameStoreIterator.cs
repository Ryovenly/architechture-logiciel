using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class GameStoreIterator : ITerator
    {
        private List<Game> _listOfGames;

        private int Position = 0;

        public GameStoreIterator(List<Game> listOfGames)
        {
            _listOfGames = listOfGames;
        }

        public bool hasNext()
        {
            if (Position > _listOfGames.Count - 1)
                return false;
            return !_listOfGames.ElementAt(Position).Equals(null);

        }

        public object Next()
        {
            return _listOfGames.ElementAt(Position++);
        }
    }
}
