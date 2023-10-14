

namespace ITaaS.Modules.Domain.Models
{
    public class AgoraLog : Entity, IAggregateRoot
    {
        public AgoraLog(string? provider, string? httpMethod, int? httpStatusCode, string? uriPath, double timeTaken, int? responseSize, string? cacheStatus)
        {
            Provider = provider;
            HttpMethod = httpMethod;
            HttpStatusCode = httpStatusCode;
            UriPath = uriPath;
            TimeTaken = timeTaken;
            ResponseSize = responseSize;
            CacheStatus = cacheStatus;
        }

        public string? Provider { get; private set; }

        public string? HttpMethod { get; private set; }

        public int? HttpStatusCode { get; private set; }

        public string? UriPath { get; private set; }

        public double TimeTaken { get; private set; }

        public int? ResponseSize { get; private set; }

        public string? CacheStatus { get; private set; }

    }
}