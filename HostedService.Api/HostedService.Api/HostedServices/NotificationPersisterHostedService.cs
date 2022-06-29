using HostedService.Api.SignalR;

namespace HostedService.Api.HostedServices
{
    public class NotificationPersisterHostedService : IHostedService
    {
        private readonly MockHub _mockHub;
        private readonly ILogger<NotificationPersisterHostedService> _logger;

        public NotificationPersisterHostedService(MockHub mockHub, ILogger<NotificationPersisterHostedService> logger)
        {
            _mockHub = mockHub;
            _logger = logger;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _mockHub.VeryImportantNotification += _mockHub_VeryImportantNotification;
            return Task.CompletedTask;
        }

        private void _mockHub_VeryImportantNotification(object? sender, EventArgs e)
        {
            _logger.LogInformation("Database was written");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _mockHub.VeryImportantNotification -= _mockHub_VeryImportantNotification;
            return Task.CompletedTask;
        }
    }
}
