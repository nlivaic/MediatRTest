using MediatRTest.Logic;

namespace MediatRTest.Infrastructure
{
    public class AppointmentRepository
    {
        private AppointmentContext _context;
        public AppointmentRepository(AppointmentContext context)
        {
            _context = context;
        }
        public void Update(Appointment appointment)
        {
            _context.Add(appointment);
            _context.SaveChanges();
        }
    }
}