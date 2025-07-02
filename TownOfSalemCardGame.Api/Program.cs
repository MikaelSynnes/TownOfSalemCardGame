using Microsoft.AspNetCore.StaticFiles;
using TownOfSalemCardGame.Api.Hubs;
using TownOfSalemCardGame.Shared;
using System.Collections.Concurrent;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddSignalR();
builder.Services.AddSingleton(new ConcurrentDictionary<string, Session>());
builder.Services.AddControllers();

var app = builder.Build();

app.MapOpenApi();
app.UseSwaggerUI(options => { options.SwaggerEndpoint("/openapi/v1.json", "My API V1"); });

app.UseHttpsRedirection();

app.UseDefaultFiles();
var provider = new FileExtensionContentTypeProvider();
provider.Mappings[".dat"] = "application/octet-stream";
provider.Mappings[".wasm"] = "application/wasm";
provider.Mappings[".br"] = "application/x-br";
provider.Mappings[".gz"] = "application/gzip";

app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = provider
});

app.UseCors();

app.MapHub<SessionHub>("/sessionHub");
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();