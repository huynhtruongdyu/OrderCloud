var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.OC_Backoffice>("OC-Backoffice");
builder.AddProject<Projects.OC_CMS>("OC-CMS");

builder.Build().Run();
