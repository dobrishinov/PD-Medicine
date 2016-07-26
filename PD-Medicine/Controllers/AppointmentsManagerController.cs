﻿namespace WebTakManager.Controllers
{
    using DataAccess.Entity;
    using DataAccess.Repository;
    using PD_Medicine.Models;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class AppointmentsManagerController : Controller
    {
        public ActionResult Index()
        {
            if (AuthenticationManager.LoggedUser == null)
                return RedirectToAction("Login", "Home");

            AppointmentsRepository appointmentsRepository = new AppointmentsRepository();
            ViewData["appointments"] = appointmentsRepository.GetAll(t => t.UserId == AuthenticationManager.LoggedUser.Id);

            return View();
        }

        [HttpGet]
        public ActionResult EditAppointment(int? id)
        {
            if (AuthenticationManager.LoggedUser == null)
                return RedirectToAction("Login", "Home");

            AppointmentsRepository AppointmentsRepository = new AppointmentsRepository();

            AppointmentEntity appointment = null;
            if (id == null)
                appointment = new AppointmentEntity();
            else
                appointment = AppointmentsRepository.GetById(id.Value);

            ViewData["appointment"] = appointment;

            return View();
        }
        [HttpPost]
        public ActionResult EditAppointment(AppointmentEntity appointment)
        {
            if (AuthenticationManager.LoggedUser == null)
                return RedirectToAction("Login", "Home");

            AppointmentsRepository appointmentsRepository = new AppointmentsRepository();
            appointmentsRepository.Save(appointment);

            return RedirectToAction("Index", "AppointmentsManager");
        }

        public ActionResult DeleteAppointment(int id)
        {
            if (AuthenticationManager.LoggedUser == null)
                return RedirectToAction("Login", "Home");

            AppointmentsRepository appointmentsRepository = new AppointmentsRepository();
            AppointmentEntity appointment = appointmentsRepository.GetById(id);
            appointmentsRepository.Delete(appointment);

            return RedirectToAction("Index", "AppointmentsManager");
        }

        //public void GetDoctors()
        //{
        //    List<SelectListItem> list = new List<SelectListItem>();
        //    foreach (var users in )
        //    {
        //        list.Add(users.FirstName);
        //    }
        //}
    }
}