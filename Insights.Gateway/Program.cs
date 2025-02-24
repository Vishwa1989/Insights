/// <summary>
/// Entry point for the application.
/// Configures and starts the web application with Kestrel server.
/// </summary>
var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to listen on port 5000
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000); // HTTP port
});

// Initialize and configure startup
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();
// Configure the HTTP request pipeline.
startup.Configure(app, app.Environment);

app.Run(); 