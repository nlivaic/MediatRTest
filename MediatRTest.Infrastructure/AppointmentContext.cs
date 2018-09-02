using System;
using MediatRTest.Logic;
using Microsoft.EntityFrameworkCore;

namespace MediatRTest.Infrastructure
{
    public class AppointmentContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }

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
