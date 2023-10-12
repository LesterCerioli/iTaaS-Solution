using ITaaS.Modules.Domain.Contracts;
using ITaaS.Modules.Domain.Models;

namespace ITaaS.Modules.Domain.Contracts
{
    public interface IAggraLogRepository
    [
        Task<AgoraLog> GetByProvider(string provider);
        

    ]
}