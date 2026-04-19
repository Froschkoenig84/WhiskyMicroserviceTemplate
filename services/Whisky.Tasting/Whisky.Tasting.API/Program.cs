var builder = WebApplication.CreateBuilder(args);

//controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); //ToDo: new stuff, checkout later
builder.Services.AddSwaggerGen();

//openApi
builder.Services.AddOpenApi();
var app = builder.Build();

//dev mode (swagger)
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(options => 
    {
        options.SwaggerEndpoint("/openapi/v1.json", "v1");
    });
}

app.UseHttpsRedirection();
app.MapControllers(); //default controller routing

app.Run();