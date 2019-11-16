using BikeShop.Data.Models;
using System.Collections.Generic;

namespace BikeShop.Interfaces
{
    public interface IAllBikes
    {
        IEnumerable<Bike> Bikes { get; }
        IEnumerable<Bike> FavouriteBikes { get; set; }
        Bike GetBike(int bikeID);
    }
}
