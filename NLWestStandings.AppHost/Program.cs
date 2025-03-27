var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NLWestStandings>("nlweststandings")
    .WithEndpoint(6999)
    .PublishAsDockerFile()
    .WithExternalHttpEndpoints()
    .AsHttp2Service();

builder.Build().Run();
