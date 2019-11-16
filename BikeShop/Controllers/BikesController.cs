using BikeShop.Interfaces;
using BikeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    public class BikesController : Controller
    {
        private readonly IBikesCategory allCategories;
        private readonly IAllBikes allBikes;

        public BikesController(IBikesCategory categories, IAllBikes bikes)
        {
            this.allCategories = categories;
            this.allBikes = bikes;
        }

        public ViewResult BikeList()
        {
            ViewBag.Title = "Test title";
            BikesListViewModel model = new BikesListViewModel();
            model.AllBikes = allBikes.Bikes;
            model.CurrentCategory = "City bikes";
            return View(model);
        }
    }
}
