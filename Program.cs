//Brandon Le
//10-26-22
//Mini Challenge 6 - MAD LIB
//Web API project that will take users inputs from the URL and it will print out a MAD LIB with the users inputs. I included a instructions page to help the user and guide them to which input comes next ex: name1, number1, etc. I also provided a example to show how it would look as a finished URL or if they were lazy and wanted to use my story.
//Peer Review: Andrea Burr i really like the program it runs nice its a supre cute mad lib and it kinda has a play again which is nice!


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
