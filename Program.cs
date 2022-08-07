using ChatSignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSignalR();

var app = builder.Build();

app.MapControllers();

app.MapHub<ChatHub>("/chatHub");

app.Run();
