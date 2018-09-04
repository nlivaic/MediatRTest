using System;
using System.Linq;
using MediatRTest.Logic;
using MediatRTest.SharedKernel;
using MediatRTest.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MediatRTest.Infrastructure
{
    public class AppointmentContext : BaseDispatchContext
    {
        public DbSet<Appointment> Appointments { get; set; }

        public AppointmentContext(DomainEventsDispatcher domainEventsDispatcher) : base(domainEventsDispatcher) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;userid=root;pwd=rootpw;port=3306;database=MediatRTest;sslmode=none;");
            }
        }
    }
}
