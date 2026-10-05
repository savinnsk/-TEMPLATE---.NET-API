using Application.Configs;
using Infra;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddDocumentation();


var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
    app.UseDocumentation(); 
//}

app.UseHttpsRedirection();

app.Run();
