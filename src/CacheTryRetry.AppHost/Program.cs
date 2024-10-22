var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.CacheTryRetry_Api>("api")
    .WithReference(cache);

builder.Build().Run();
