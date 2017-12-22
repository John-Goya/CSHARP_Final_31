using JG_Final.Models;
using PerpetuumSoft.Knockout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JG_Final.Controllers
{

    public class HomeController : Controller
    //public class FooController : KnockoutController
    {   
        // GET: Home              
        public ActionResult Index()
        {
            
            InitializeViewBag("Better list");
            var model = new BetterListModel
            {
                AllItems = new List<string> { "Fries", "Eggs Benedict", "Ham", "Cheese" },
                SelectedItems = new List<string> { "Ham" }
            };
            return View(model);
            //return View();
        }

        private void InitializeViewBag(string v)
        {
            //throw new NotImplementedException();
        }

        public ActionResult AddItem(BetterListModel model)
        {
            model.AddItem();
            return Json(model);
        }

        public ActionResult RemoveSelected(BetterListModel model)
        {
            model.RemoveSelected();
            return Json(model);
        }

        public ActionResult SortItems(BetterListModel model)
        {
            model.SortItems();
            return Json(model);
        }


    }
}