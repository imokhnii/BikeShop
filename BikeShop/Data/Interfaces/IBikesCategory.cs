using BikeShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Interfaces
{
    public interface IBikesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
