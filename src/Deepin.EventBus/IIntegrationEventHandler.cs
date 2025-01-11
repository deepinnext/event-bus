using MassTransit;

namespace Deepin.EventBus;
public interface IIntegrationEventHandler<in TIntegrationEvent> : IConsumer<TIntegrationEvent>
    where TIntegrationEvent : IntegrationEvent
{ }
