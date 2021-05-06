using Microsoft.Extensions.Logging;

namespace GomokuRpc.Storage.Services
{
    public class StorageService : Contracts.Protos.StorageService.StorageServiceBase
    {
        private readonly ILogger<StorageService> _logger;
        public StorageService(ILogger<StorageService> logger)
        {
            _logger = logger;
        }
    }
}
