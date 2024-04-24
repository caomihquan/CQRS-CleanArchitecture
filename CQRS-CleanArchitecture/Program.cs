using MediatR;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder
    .Services
    .Scan(
        selector => selector
            .FromAssemblies(
                Infrastructure.AssemblyReference.Assembly,
                Persistence.AssemblyReference.Assembly)
            .AddClasses(false)
            .AsImplementedInterfaces()
            .WithScopedLifetime());

//builder.Services.AddControllers();
builder.Services.AddMediatR(cf => cf.RegisterServicesFromAssemblies(Application.AssemblyReference.Assembly));
builder
    .Services
    .AddControllers()
    .AddApplicationPart(Presentation.AssemblyReference.Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
