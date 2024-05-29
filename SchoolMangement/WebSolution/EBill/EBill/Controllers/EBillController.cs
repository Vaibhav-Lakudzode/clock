using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EBill.Controllers
{
    public class EBillController : Controller
    {
        // GET: EBill
        public ActionResult Index()
        {
            return View();
        }
    }
}