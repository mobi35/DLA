using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DLA_Thesis.Models;
using DLA_Thesis.Data.Model.Interface;

namespace DLA_Thesis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeeRepository feeRepo;
        private readonly IBillingRepository billingRepo;
        private readonly ITeacherRepository teacherRepo;
        private readonly IStudentRepository studentRepo;
        public HomeController(IFeeRepository feeRepo, IBillingRepository billingRepo, ITeacherRepository teacherRepo, IStudentRepository studentRepo)
        {
            this.feeRepo = feeRepo;
            this.billingRepo = billingRepo;
            this.teacherRepo = teacherRepo;
            this.studentRepo = studentRepo;
        }
        public IActionResult Index()
        {
           

            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Client()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Enroll()
        {
            return View();
        }

    }
}
