using GomokuRpc.Protos;

namespace GomokuRpc.Models
{
    public class Game
    {
        public int[,] Board = new int[15, 15];
        public PlayerId CurrentPlayer = PlayerId.Undefined;
        public int TurnCounter { get; set; } = 0;
    }
}
