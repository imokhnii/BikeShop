using BikeShop.Data.Models;
using BikeShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Mocks
{
    public class MockBikes : IAllBikes
    {
        private readonly IBikesCategory categories = new MockCategory();

        public IEnumerable<Bike> Bikes
        {
            get
            {
                return new List<Bike>
                {
                    new Bike { Model = "Schwinn", Price = 300, Available = true, IsFavourite = true, Category = categories.AllCategories.Last() },
                    new Bike { Model = "Trek", Price = 500, Available = true, IsFavourite = true, Category = categories.AllCategories.First() },
                    new Bike { Model = "Giant", Price = 700, Available = true, IsFavourite = true, Category = categories.AllCategories.First() }
                };
            }
        }

        public IEnumerable<Bike> FavouriteBikes { get; set; }

        public Bike GetBike(int bikeID)
        {
            throw new NotImplementedException();
        }
    }
}
