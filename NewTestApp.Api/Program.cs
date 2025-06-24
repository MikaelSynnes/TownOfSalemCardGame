using Microsoft.AspNetCore.SignalR;
using NewTestApp.Api.Hubs;
using NewTestApp.Shared;
using System.Collections.Concurrent;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add CORS policy
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

// Register the session store as a singleton for DI
builder.Services.AddSingleton(new ConcurrentDictionary<string, Session>());

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // Comment out HTTPS redirection in development to avoid SignalR negotiation issues
    // app.UseHttpsRedirection();
}
else
{
    app.UseHttpsRedirection();
}

app.UseCors();

app.MapHub<SessionHub>("/sessionHub");
app.MapControllers();

app.Run();
