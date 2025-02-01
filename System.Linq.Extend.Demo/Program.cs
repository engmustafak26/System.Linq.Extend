
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Caching.Memory;
using System.Linq.Extend.Demo.Handlers;
using System.Linq.Extend.Demo.Mediator;

namespace System.Linq.Extend.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddTransient<IMediator, MediatorManager>();
            builder.Services.AddMemoryCache();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            System.Linq.Extend.DependecyInjector.Inject(app.Services); // register
            System.Linq.Extend.EventSubscriber
                .RegisterEventSubscriber(
                    Event.ToArray,
                    beforeExecution: (serviceProvider, source, metaObject) =>
                        {
                            var mediator = serviceProvider.GetRequiredService<IMediator>();

                            mediator.Send("audit", source);
                            var cacheResult = mediator.Send("cache", source);
                            if (cacheResult.IsSuccess == true) // found key with data
                            {
                                return cacheResult;
                            }

                            return mediator.Send(metaObject, source);
                        },
                    afterExecution: (serviceProvider, source, result, metaObject) =>
                            {
                                var mediator = serviceProvider.GetRequiredService<IMediator>();

                                mediator.Send("audit", source, result);
                                mediator.Send("cache", source, result);

                                return mediator.Send(metaObject, source, result);
                            });


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
        }
    }
}
