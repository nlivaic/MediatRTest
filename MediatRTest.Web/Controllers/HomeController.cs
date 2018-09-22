using System;
using System.Linq;
using MediatRTest.Infrastructure;
using MediatRTest.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatRTest.Web.Controllers
{
    public class HomeController : Controller
    {
        private AppointmentRepository _repo;
        public HomeController(AppointmentRepository repository)
        {
            _repo = repository;
        }

        public IActionResult Index()
        {
            Appointment appointment = new Appointment();
            //appointment.Schedule();
            appointment.Confirm();
            _repo.Update(appointment);
            return View();
        }
    }
}