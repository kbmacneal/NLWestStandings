var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.NLWestStandings>("nlweststandings")
    .WithExternalHttpEndpoints();

builder.Build().Run();
