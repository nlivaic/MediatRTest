using System.Threading;
using System.Threading.Tasks;
using MediatRTest.Logic;
using MediatRTest.SharedKernel.Interfaces;
using Microsoft.Extensions.Logging;

namespace MediatRTest.Infrastructure
{
    public class AnotherAppointmentScheduledHandler : IEventHandler<AppointmentScheduled>
    {
        private ILogger<AppointmentScheduledHandler> _logger;
        public AnotherAppointmentScheduledHandler(ILogger<AppointmentScheduledHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(AppointmentScheduled notification, CancellationToken cancellationToken)
        {
            // Handling logic.
            _logger.LogInformation("Another handling of the AppointmentScheduled event.");
            return Task.CompletedTask;
        }
    }
}