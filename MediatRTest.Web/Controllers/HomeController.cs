using System;
using System.Linq;
// using MediatR;
using MediatRTest.Infrastructure;
using MediatRTest.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatRTest.Web.Controllers
{
    public class HomeController : Controller
    {
        private AppointmentRepository _repo;
        // private IMediator _mediator;
        public HomeController(AppointmentRepository repository/*, IMediator mediator*/)
        {
            _repo = repository;
            // _mediator = mediator;
        }

        public IActionResult Index()
        {
            Appointment appointment = new Appointment();
            appointment.Schedule();
            _repo.Update(appointment);
            // foreach (SharedKernel.Interfaces.IDomainEvent domainEvent in appointment.DomainEvents)
            // {
            //     _mediator.Publish(domainEvent);
            // }
            return View();
        }
    }
}