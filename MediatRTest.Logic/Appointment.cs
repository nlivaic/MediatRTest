using System;
using MediatRTest.SharedKernel;

namespace MediatRTest.Logic
{
    public class Appointment : Entity<Guid>
    {
        public Guid Id { get; private set; }
        public string CustomerName { get; private set; }

        public Appointment() : base()
        {
            Id = Guid.NewGuid();
            CustomerName = "John Doe";
        }
        public void Schedule()
        {
            AddDomainEvent(new AppointmentScheduled("A message describing the scheduling event."));
        }
        public void Confirm()
        {
            AddDomainEvent(new AppointmentConfirmed("A message describing the confirming event."));
        }


    }
}