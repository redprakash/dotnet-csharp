using HostedService.Api.SignalR;

namespace HostedService.Api.HostedServices
{
    public class SmsNotifierHostedService : IHostedService
    {
        private readonly MockHub _mockHub;
        private readonly ILogger<SmsNotifierHostedService> _logger;

        public SmsNotifierHostedService(MockHub mockHub, ILogger<SmsNotifierHostedService> logger)
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
            _logger.LogInformation("SMS was sent");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _mockHub.VeryImportantNotification -= _mockHub_VeryImportantNotification;
            return Task.CompletedTask;
        }
    }
}
