using System;
using MediatRTest.SharedKernel.Interfaces;

namespace MediatRTest.Logic
{
    public class AppointmentScheduled : IDomainEvent
    {
        public AppointmentScheduled(string message)
        {
            SomeEventMessage = message;
        }
        public string SomeEventMessage { get; set; }
    }
}
