using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Deepin.EventBus.RabbitMQ;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEventBusRabbitMQ(this IServiceCollection services, RabbitMQConfiguration mqConfig, Assembly assembly)
    {
        services.AddMassTransit(config =>
        {
            config.AddConsumers(assembly);
            config.UsingRabbitMq((ctx, mq) =>
            {
                mq.Host(mqConfig.HostName, mqConfig.VirtualHost, h =>
                {
                    h.Username(mqConfig.Username);
                    h.Password(mqConfig.Password);

                });
                mq.ReceiveEndpoint(mqConfig.QueueName, x =>
                {
                    x.ConfigureConsumers(ctx);
                });
            });
        });
        return services;
    }
}