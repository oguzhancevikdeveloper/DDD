﻿namespace DDD.Domain.Abstractions;

public interface IEntity<T> : IEntity
{
    public T Id { get; set; }
}

public interface IEntity
{
    public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LasModified { get; set; }
    public string? LastModifiedBy { get; set; }
}