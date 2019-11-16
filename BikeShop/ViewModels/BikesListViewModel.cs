using BikeShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.ViewModels
{
    public class BikesListViewModel
    {
        public IEnumerable<Bike> AllBikes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
