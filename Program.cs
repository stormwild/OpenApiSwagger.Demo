var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!")
    .WithOpenApi(operation => new(operation)
    {
        Summary = "Hello World",
        Tags = [new() { Name = "HelloWorld" }]
    });

app.Run();
