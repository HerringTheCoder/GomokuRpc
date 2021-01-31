using System.Threading.Tasks;
using GomokuRpc.Protos;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GomokuRpc.Services
{
    public class GameService : Protos.GameService.GameServiceBase
    {
        private readonly ILogger<GameService> _logger;

        public GameService(ILogger<GameService> logger)
        {
            _logger = logger;
        }

        public override Task<MoveResponse> MakeMove(MoveRequest request, ServerCallContext context)
        {
            return base.MakeMove(request,context);
        }

        public override Task<CreateRoomResponse> CreateRoom(CreateRoomRequest request, ServerCallContext context)
        {
            return base.CreateRoom(request, context);
        }

        public override Task<ResetResponse> ResetBoard(ResetRequest request, ServerCallContext context)
        {
            return base.ResetBoard(request, context);
        }
    }
}
