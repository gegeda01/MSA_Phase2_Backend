var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("reddit", configureClient: client =>
{
    client.BaseAddress = new Uri("https://www.reddit.com/dev/api");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => { c.InjectStylesheet("swagger/swagger_custom.css"); 
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"); });
}
else if(app.Environment.IsStaging())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        var heading = Path.Combine(app.Environment.ContentRootPath, "swagger/custom_heading.html");
        c.HeadContent = File.ReadAllText(heading);
    });

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
