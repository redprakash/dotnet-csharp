namespace HostedService.Api.HostedServices
{
    public class SmsStatusUpdaterHostedService : BackgroundService
    {
        private readonly ILogger<SmsStatusUpdaterHostedService> _logger;

        public SmsStatusUpdaterHostedService(ILogger<SmsStatusUpdaterHostedService> logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Execute called");
             //here in the middle task is done
             while (!stoppingToken.IsCancellationRequested)
             {
                 _logger.LogInformation("checking the sms service");
                 await Task.Delay(TimeSpan.FromSeconds(5));
             }
            _logger.LogInformation("Execute complete");

        }
    }
}
