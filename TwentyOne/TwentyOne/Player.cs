using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        
        
        
        
        
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name  { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static Game operator+ (Game game, Player player)  // Operator overload requires you to add the parameters that you want to use with the operator.  Adding Game plus Player.
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator- ( Game game, Player player)  // Operator overload requires you to add the parameters that you want to use with the operator.  Adding Game minus Player.
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
