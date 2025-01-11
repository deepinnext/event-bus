﻿namespace Deepin.EventBus.RabbitMQ;
public class RabbitMQConfiguration
{
    public static string ConfigurationKey = "RabbitMQ";
    public required string HostName { get; set; }
    public required string VirtualHost { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
    public required string QueueName { get; set; }
}
