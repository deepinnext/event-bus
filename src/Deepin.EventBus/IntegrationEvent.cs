namespace Deepin.EventBus;

public abstract class IntegrationEvent
{
    public IntegrationEvent()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }
    public IntegrationEvent(Guid id, DateTime creationDateTime)
    {
        Id = id;
        CreatedAt = DateTime.UtcNow;
    }
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
}
