using System;
using MediatRTest.SharedKernel.Interfaces;

namespace MediatRTest.Logic
{
    public class AppointmentConfirmed : IDomainEvent
    {
        public AppointmentConfirmed(string message)
        {
            SomeEventMessage = message;
        }
        public string SomeEventMessage { get; set; }
    }
}
