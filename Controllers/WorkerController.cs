using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkerData.DAL;
using WorkerData.Models;

namespace WorkerData.Controllers
{
    public class WorkerController : Controller
    {
        private readonly  WorkerDbContext _context;
        public WorkerController(WorkerDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var workers = _context.Workers.ToList();
            List<WorkerViewModel> workerList = new List<WorkerViewModel>();

            if(workers != null)
            {
               //List<WorkerViewModel> workerList = new List<WorkerViewModel>();
               foreach(var w in workers)
               {
                  var WorkerViewModel = new WorkerViewModel()
                  {
                    Id = w.Id, FirstName = w.FirstName, LastName = w.LastName,
                    DateOfBirth = w.DateOfBirth, Email = w.Email, Salary = w.Salary
                  };
                  workerList.Add(WorkerViewModel);
               }
                return View(workerList);
            }
            return View(workerList);
        }
    }
}