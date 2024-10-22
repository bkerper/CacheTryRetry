using CacheTryRetry.Api.Models;

namespace CacheTryRetry.Api.Endpoints
{
    public static class IngestEndpoints
    {
        public static void AddIngestEndpoints(this WebApplication app) 
        {
            app.MapGet("/api/ingest", () =>
            {
                return new IngestResponse()
                {
                    Message = "You have called the ingest endpoint"
                };
            });
        } 
    }
}
