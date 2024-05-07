using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var db = builder
    .AddPostgres("postgres")
    .AddDatabase("db");

var api = builder
    .AddProject<AspireDemo_Api>("api")
    .WithReference(db);

builder
    .AddProject<AspireDemo_Web>("web")
    .WithReference(api);

builder.Build().Run();