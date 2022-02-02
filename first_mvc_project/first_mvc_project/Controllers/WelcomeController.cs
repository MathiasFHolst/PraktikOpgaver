using first_mvc_project.Classes;
using first_mvc_project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace first_mvc_project.Controllers
{
    public class WelcomeController : Controller
    {
        public ActionResult Index()
        {
            // Send ViewData Model to View with randomized data from DataSet
            return View("Welcome", DataAccess.getViewData());
        }

        public ViewData getNewData()
        {
            return DataAccess.getViewData();
        }
    }
}