using HostedService.Api.HostedServices;
using HostedService.Api.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddLogging(x => x.AddSeq());
builder.Services.AddSingleton<MockHub>();
builder.Services.AddHostedService<SmsNotifierHostedService>();
builder.Services.AddHostedService<NotificationPersisterHostedService>();
builder.Services.AddHostedService<SmsStatusUpdaterHostedService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
