namespace DDD.Domain.Events;

public record OrderUpdatedEvent(Order order) : IDomainEvent;
