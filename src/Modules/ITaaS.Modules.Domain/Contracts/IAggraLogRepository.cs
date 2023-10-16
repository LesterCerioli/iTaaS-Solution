using ITaaS.Modules.Domain.Models;

namespace ITaaS.Modules.Domain.Contracts
{
    public interface IAggraLogRepository
    {
         Task<AgoraLog> GetByProvider(string provider);

         Task<AgoraLog> GetByHttpMethod(string httpMethod);

         Task<AgoraLog> GetByHttpStatusCode(int httpStatusCode);
         
         Task<IEnumerable<AgoraLog>> GetList();

         Task Add(AgoraLog agoraLog);

         void Update(AgoraLog agoraLog);

         void Remove(AgoraLog agoraLog);
    }
}