
using LPGCylinderSystem.Data.Stores;
using LPGCylinderSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LPGCylinderSystem.Controllers
{
    [Authorize(Roles="ADMIN")]
    public class AdminController : Controller
    {
    
    
    //just git testing
    //just git testing
    
    
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ClassRepository<ApplicationUser> _classRepository;
        // GET: AdminController
        public AdminController(UserManager<ApplicationUser> userManager, ClassRepository<ApplicationUser> classRepository)
        {
            _userManager = userManager;
            _classRepository = classRepository;
        }
        public ActionResult Index()
        { 
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
           IEnumerable<ApplicationUser> users= _classRepository.GetuserssAsync();

            int flag= 0;
            foreach(var user in users)
            {
                if (user.Complaints != null)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                ViewData["Error"] = "Error";
                return View();
            }
            else
            {
                return View(users);
            }
            
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Netbanking netbanking, CancellationToken token)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var netbankingg = new Netbanking
                    {
                        _id=ObjectId.GenerateNewId().ToString(),
                        Username = netbanking.Username,
                        Password=netbanking.Password,
                        balance=netbanking.balance,
                        Bank=netbanking.Bank
                    };
                    await _classRepository.CreateNetbankingAsync(netbanking,token);
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    return  View();
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateCard()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateCard(Dcard card, CancellationToken token)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var cardd = new Dcard
                    {
                        _id = ObjectId.GenerateNewId().ToString(),
                       CardNumber=card.CardNumber,
                        balance = card.balance,
                        month=card.month,
                        year=card.year,
                        CVV=card.CVV,mailid=card.mailid
                  
                    };
                    await _classRepository.CreateCardAsync(cardd, token);
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
