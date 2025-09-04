var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();

var app = builder.Build();

//TEST

app.MapOpenApi();

app.Run();