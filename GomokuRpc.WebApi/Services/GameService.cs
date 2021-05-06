using System.Threading.Tasks;
using GomokuRpc.Contracts.Protos;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GomokuRpc.WebApi.Services
{
    public class GameService : Contracts.Protos.GameService.GameServiceBase
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
