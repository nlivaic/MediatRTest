using MediatRTest.Logic;
using MediatRTest.SharedKernel.Interfaces;
using Microsoft.Extensions.Logging;

namespace MediatRTest.Infrastructure
{
    public class AppointmentScheduledHandler : IEventHandler<AppointmentScheduled>
    {
        private ILogger<AppointmentScheduledHandler> _logger;
        public AppointmentScheduledHandler(ILogger<AppointmentScheduledHandler> logger)
        {
            _logger = logger;
        }

        public void Handle(AppointmentScheduled args)
        {
            // Handling logic.
            _logger.LogInformation("Handling AppointmentScheduled event.");
        }
    }
}