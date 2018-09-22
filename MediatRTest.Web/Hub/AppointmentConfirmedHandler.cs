using System.Threading;
using System.Threading.Tasks;
using MediatRTest.Logic;
using MediatRTest.SharedKernel.Interfaces;
using Microsoft.Extensions.Logging;

namespace MediatRTest.Infrastructure
{
    public class AppointmentConfirmedHandler : IEventHandler<AppointmentConfirmed>
    {
        private ILogger<AppointmentConfirmedHandler> _logger;
        public AppointmentConfirmedHandler(ILogger<AppointmentConfirmedHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(AppointmentConfirmed notification, CancellationToken cancellationToken)
        {
            // Handling logic.
            _logger.LogInformation("Handling AppointmentConfirmed event.");
            return Task.CompletedTask;
        }
    }
}