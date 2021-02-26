using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPGCylinderSystem.Controllers
{
    public class DeliveryBoyController : Controller
    {
        [Authorize(Roles = "DELIVERYBOY")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
