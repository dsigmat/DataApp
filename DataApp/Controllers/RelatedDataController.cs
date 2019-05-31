using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataApp.Controllers
{
    public class RelatedDataController : Controller
    {
        private ISupplierRepository supplierRepo;
        private IGenericRepository<ContactDetails> detailsRepo;
        private IGenericRepository<ContactLocation> locsRepo;
        public RelatedDataController(ISupplierRepository repo, 
            IGenericRepository<ContactDetails> dRepo, 
            IGenericRepository<ContactLocation> lRepo)
        {
            supplierRepo = repo;
            detailsRepo = dRepo;
            locsRepo = lRepo;
        }
        public IActionResult Index()
        {
            return View(supplierRepo.GetAll());
        }

        public IActionResult Contacts()
        {
            return View(detailsRepo.GetAll());
        }

        public IActionResult Locations()
        {
            return View(locsRepo.GetAll());
        }
    }
}